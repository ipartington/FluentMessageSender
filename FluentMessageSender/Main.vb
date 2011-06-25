Namespace Fluent
    Public Class Main
        Public Sub test(ByVal sender As Fluent.MessageSender)
            sender.SendText("Hi").From("Iain").To("Me")
            sender.SendText("").From("").To("")
            sender.SendText("").From(toAddress.Home).To("iain")

        End Sub
    End Class
End Namespace