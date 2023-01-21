﻿
Namespace My

    'This class allows you to handle specific events on the settings class:
    ' The SettingChanging event is raised before a setting's value is changed.
    ' The PropertyChanged event is raised after a setting's value is changed.
    ' The SettingsLoaded event is raised after the setting values are loaded.
    ' The SettingsSaving event is raised before the setting values are saved.
    Partial Friend NotInheritable Class MySettings

        Public Sub New()
            Try
                My.Settings.username = admin1.TextBox1.Text
                My.Settings.password = admin1.TextBox2.Text
            Catch ex As Exception
            End Try
        End Sub
    End Class
End Namespace
