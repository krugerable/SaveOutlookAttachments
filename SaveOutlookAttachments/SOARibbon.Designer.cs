namespace SaveOutlookAttachments
{
    partial class SOARibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public SOARibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.btnSaveAttachments = this.Factory.CreateRibbonButton();
            this.btnToggleMonitor = this.Factory.CreateRibbonToggleButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Label = "Save Outlook Attachments";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.btnSaveAttachments);
            this.group1.Items.Add(this.btnToggleMonitor);
            this.group1.Label = "Attachment Options";
            this.group1.Name = "group1";
            // 
            // btnSaveAttachments
            // 
            this.btnSaveAttachments.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnSaveAttachments.Image = global::SaveOutlookAttachments.Properties.Resources.envelope_2;
            this.btnSaveAttachments.Label = "Save Attachments From Inbox";
            this.btnSaveAttachments.Name = "btnSaveAttachments";
            this.btnSaveAttachments.ShowImage = true;
            this.btnSaveAttachments.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnSaveAttachments_Click);
            // 
            // btnToggleMonitor
            // 
            this.btnToggleMonitor.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnToggleMonitor.Image = global::SaveOutlookAttachments.Properties.Resources.envelope_18;
            this.btnToggleMonitor.Label = "Watch Inbox For New Mail";
            this.btnToggleMonitor.Name = "btnToggleMonitor";
            this.btnToggleMonitor.ShowImage = true;
            // 
            // SOARibbon
            // 
            this.Name = "SOARibbon";
            this.RibbonType = "Microsoft.Outlook.Mail.Read";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.SOARibbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnSaveAttachments;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton btnToggleMonitor;
    }

    partial class ThisRibbonCollection
    {
        internal SOARibbon SOARibbon
        {
            get { return this.GetRibbon<SOARibbon>(); }
        }
    }
}
