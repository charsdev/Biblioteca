using System.Windows.Forms;

namespace Biblioteca.Utils
{
    public struct MessageResult
    {
        public string text, caption;
        public MessageBoxButtons MessageBoxButton;
        public MessageBoxIcon MessageBoxIcon;

        public MessageResult(string text, string caption, MessageBoxButtons messageBoxButton, MessageBoxIcon messageBoxIcon)
        {
            this.text = text;
            this.caption = caption;
            MessageBoxButton = messageBoxButton;
            MessageBoxIcon = messageBoxIcon;
        }

    }

    public static class MessageBoxExtension
    {
        public static DialogResult Show(MessageResult messageResult)
        {
            return MessageBox.Show(messageResult.text, messageResult.caption, messageResult.MessageBoxButton, messageResult.MessageBoxIcon);
        }

    }
}
