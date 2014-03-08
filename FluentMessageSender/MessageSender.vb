Namespace Fluent
    Public Class MessageSender
        Private ReadOnly _messageSender As IMessageSender

        Public Sub New (ByVal sender As IMessageSender)
            _messageSender = sender
        End Sub

        Public Function SendText (ByVal text As String) As SendExpression
            Return New SendExpression (text, _messageSender)
        End Function

        Public Class SendExpression
            Implements ToExpression

            Private ReadOnly _text As String
            Private ReadOnly _messageSender As IMessageSender
            Private _sender As String

            Public Sub New(ByVal text As String, ByVal messageSender As IMessageSender)
                _text = text
                _messageSender = messageSender
            End Sub

            Public Function From(ByVal sender As FromAddress) As ToExpression
                _sender = sender
                Return Me
            End Function

            Public Sub ToExpression(ByVal receiver As String) Implements ToExpression.To
                _messageSender.SendMessage(_text, _sender, receiver)
            End Sub
        End Class
    End Class
End Namespace

