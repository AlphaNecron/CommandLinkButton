namespace System.Windows.Forms.CommandLinkButton
{
    public partial class CommandLinkButton : Button
    {
        private const int BS_COMMANDLINK = 0x0000000E;
        protected override CreateParams CreateParams
        {
            get
            {
                var cParams = base.CreateParams;
                cParams.Style |= BS_COMMANDLINK;
                return cParams;
            }
        }
        public CommandLinkButton()
        {
            InitializeComponent();
            this.FlatStyle = FlatStyle.System;
        }
    }
}