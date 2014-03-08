Imports FluentMessageSender.Fluent
Public Class Main
    Public Sub SendMessage(ByVal sender As MessageSender)

        sender.SendText("Hi").From("Iain").To("Me")
        sender.SendText("").From("").To("")
        sender.SendText("").From(FromAddress.Iain).To("iain")

    End Sub
End Class