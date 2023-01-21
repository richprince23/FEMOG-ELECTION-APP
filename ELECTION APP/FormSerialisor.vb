Imports System.IO
Imports System.Windows.Forms
Imports System.Reflection
Imports System.Xml
Imports System.Diagnostics

Namespace FormSerialisation
	Public NotInheritable Class FormSerialisor
		Private Sub New()
		End Sub
		'
'     * Drop this class into your project, and add the following line at the top of any class/form that wishes to use it...
'       using FormSerialisation;
'       To use the code, simply call FormSerialisor.Serialise(FormOrControlToBeSerialised, FullPathToXMLFile)
'     * 
'     * For more details, see http://www.codeproject.com/KB/dialog/SavingTheStateOfAForm.aspx
'     * 
'     * Last updated 13th June '10 to account for the odd behaviour of the two Panel controls in a SplitContainer (see the article)
'     

		Public Shared Sub Serialise(c As Control, XmlFileName As String)
			Dim xmlSerialisedForm As New XmlTextWriter(XmlFileName, System.Text.Encoding.[Default])
			xmlSerialisedForm.Formatting = Formatting.Indented
			xmlSerialisedForm.WriteStartDocument()
			xmlSerialisedForm.WriteStartElement("ChildForm")
			' enumerate all controls on the form, and serialise them as appropriate
			AddChildControls(xmlSerialisedForm, c)
			xmlSerialisedForm.WriteEndElement()
			' ChildForm
			xmlSerialisedForm.WriteEndDocument()
			xmlSerialisedForm.Flush()
			xmlSerialisedForm.Close()
		End Sub

		Private Shared Sub AddChildControls(xmlSerialisedForm As XmlTextWriter, c As Control)
			For Each childCtrl As Control In c.Controls
				If Not (TypeOf childCtrl Is Label) Then
					' serialise this control
					xmlSerialisedForm.WriteStartElement("Control")
					xmlSerialisedForm.WriteAttributeString("Type", childCtrl.[GetType]().ToString())
					xmlSerialisedForm.WriteAttributeString("Name", childCtrl.Name)
					If TypeOf childCtrl Is TextBox Then
						xmlSerialisedForm.WriteElementString("Text", DirectCast(childCtrl, TextBox).Text)
					ElseIf TypeOf childCtrl Is ComboBox Then
						xmlSerialisedForm.WriteElementString("Text", DirectCast(childCtrl, ComboBox).Text)
						xmlSerialisedForm.WriteElementString("SelectedIndex", DirectCast(childCtrl, ComboBox).SelectedIndex.ToString())
					ElseIf TypeOf childCtrl Is ListBox Then
						' need to account for multiply selected items
						Dim lst As ListBox = DirectCast(childCtrl, ListBox)
						If lst.SelectedIndex = -1 Then
							xmlSerialisedForm.WriteElementString("SelectedIndex", "-1")
						Else
							For i As Integer = 0 To lst.SelectedIndices.Count - 1
								xmlSerialisedForm.WriteElementString("SelectedIndex", (lst.SelectedIndices(i).ToString()))
							Next
						End If
					ElseIf TypeOf childCtrl Is CheckBox Then
						xmlSerialisedForm.WriteElementString("Checked", DirectCast(childCtrl, CheckBox).Checked.ToString())
					End If
					' this next line was taken from http://stackoverflow.com/questions/391888/how-to-get-the-real-value-of-the-visible-property
					' which dicusses the problem of child controls claiming to have Visible=false even when they haven't, based on the parent
					' having Visible=true
					Dim visible As Boolean = CBool(GetType(Control).GetMethod("GetState", BindingFlags.Instance Or BindingFlags.NonPublic).Invoke(childCtrl, New Object() {2}))
					xmlSerialisedForm.WriteElementString("Visible", visible.ToString())
					' see if this control has any children, and if so, serialise them
					If childCtrl.HasChildren Then
						If TypeOf childCtrl Is SplitContainer Then
							' handle this one as a special case
							AddChildControls(xmlSerialisedForm, DirectCast(childCtrl, SplitContainer).Panel1)
							AddChildControls(xmlSerialisedForm, DirectCast(childCtrl, SplitContainer).Panel2)
						Else
							AddChildControls(xmlSerialisedForm, childCtrl)
						End If
					End If
						' Control
					xmlSerialisedForm.WriteEndElement()
				End If
			Next
		End Sub

		Public Shared Sub Deserialise(c As Control, XmlFileName As String)
			If File.Exists(XmlFileName) Then
				Dim xmlSerialisedForm As New XmlDocument()
				xmlSerialisedForm.Load(XmlFileName)
				Dim topLevel As XmlNode = xmlSerialisedForm.ChildNodes(1)
				For Each n As XmlNode In topLevel.ChildNodes
					SetControlProperties(DirectCast(c, Control), n)
				Next
			End If
		End Sub

		Private Shared Sub SetControlProperties(currentCtrl As Control, n As XmlNode)
			' get the control's name and type
			Dim controlName As String = n.Attributes("Name").Value
			Dim controlType As String = n.Attributes("Type").Value
			' find the control
			Dim ctrl As Control() = currentCtrl.Controls.Find(controlName, True)
					' can't find the control
			If ctrl.Length = 0 Then
			Else
				Dim ctrlToSet As Control = GetImmediateChildControl(ctrl, currentCtrl)
				If ctrlToSet IsNot Nothing Then
					If ctrlToSet.[GetType]().ToString() = controlType Then
						' the right type too ;-)
						Select Case controlType
							Case "System.Windows.Forms.TextBox"
								DirectCast(ctrlToSet, System.Windows.Forms.TextBox).Text = n("Text").InnerText
								Exit Select
							Case "System.Windows.Forms.ComboBox"
								DirectCast(ctrlToSet, System.Windows.Forms.ComboBox).Text = n("Text").InnerText
								DirectCast(ctrlToSet, System.Windows.Forms.ComboBox).SelectedIndex = Convert.ToInt32(n("SelectedIndex").InnerText)
								Exit Select
							Case "System.Windows.Forms.ListBox"
								' need to account for multiply selected items
								Dim lst As ListBox = DirectCast(ctrlToSet, ListBox)
								Dim xnlSelectedIndex As XmlNodeList = n.SelectNodes("SelectedIndex")
								For i As Integer = 0 To xnlSelectedIndex.Count - 1
									lst.SelectedIndex = Convert.ToInt32(xnlSelectedIndex(i).InnerText)
								Next
								Exit Select
							Case "System.Windows.Forms.CheckBox"
								DirectCast(ctrlToSet, System.Windows.Forms.CheckBox).Checked = Convert.ToBoolean(n("Checked").InnerText)
								Exit Select
						End Select
						ctrlToSet.Visible = Convert.ToBoolean(n("Visible").InnerText)
						' if n has any children that are controls, deserialise them as well
						If n.HasChildNodes AndAlso ctrlToSet.HasChildren Then
							Dim xnlControls As XmlNodeList = n.SelectNodes("Control")
							For Each n2 As XmlNode In xnlControls
								SetControlProperties(ctrlToSet, n2)
							Next
						End If
							' not the right type
					Else
					End If
						' can't find a control whose parent is the current control
				Else
				End If
			End If
		End Sub

		Private Shared Function GetImmediateChildControl(ctrl As Control(), currentCtrl As Control) As Control
			Dim c As Control = Nothing
			For i As Integer = 0 To ctrl.Length - 1
				If (ctrl(i).Parent.Name = currentCtrl.Name) OrElse (TypeOf currentCtrl Is SplitContainer AndAlso ctrl(i).Parent.Parent.Name = currentCtrl.Name) Then
					c = ctrl(i)
					Exit For
				End If
			Next
			Return c
		End Function

	End Class
End Namespace
