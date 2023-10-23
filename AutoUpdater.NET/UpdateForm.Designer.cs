using System.Threading;

namespace AutoUpdaterDotNET
{
    sealed partial class UpdateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateForm));
            labelUpdate = new System.Windows.Forms.Label();
            labelDescription = new System.Windows.Forms.Label();
            labelReleaseNotes = new System.Windows.Forms.Label();
            buttonUpdate = new System.Windows.Forms.Button();
            buttonRemindLater = new System.Windows.Forms.Button();
            pictureBoxIcon = new System.Windows.Forms.PictureBox();
            buttonSkip = new System.Windows.Forms.Button();
            releaseNote = new System.Windows.Forms.RichTextBox();
            panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelUpdate
            // 
            resources.ApplyResources(labelUpdate, "labelUpdate");
            labelUpdate.Name = "labelUpdate";
            // 
            // labelDescription
            // 
            resources.ApplyResources(labelDescription, "labelDescription");
            labelDescription.Name = "labelDescription";
            // 
            // labelReleaseNotes
            // 
            resources.ApplyResources(labelReleaseNotes, "labelReleaseNotes");
            labelReleaseNotes.Name = "labelReleaseNotes";
            // 
            // buttonUpdate
            // 
            resources.ApplyResources(buttonUpdate, "buttonUpdate");
            buttonUpdate.Image = Properties.Resources.download;
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += ButtonUpdateClick;
            // 
            // buttonRemindLater
            // 
            resources.ApplyResources(buttonRemindLater, "buttonRemindLater");
            buttonRemindLater.Image = Properties.Resources.clock_go;
            buttonRemindLater.Name = "buttonRemindLater";
            buttonRemindLater.UseVisualStyleBackColor = true;
            buttonRemindLater.Click += ButtonRemindLaterClick;
            // 
            // pictureBoxIcon
            // 
            pictureBoxIcon.Image = Properties.Resources.update;
            resources.ApplyResources(pictureBoxIcon, "pictureBoxIcon");
            pictureBoxIcon.Name = "pictureBoxIcon";
            pictureBoxIcon.TabStop = false;
            // 
            // buttonSkip
            // 
            resources.ApplyResources(buttonSkip, "buttonSkip");
            buttonSkip.DialogResult = System.Windows.Forms.DialogResult.Abort;
            buttonSkip.Image = Properties.Resources.hand_point;
            buttonSkip.Name = "buttonSkip";
            buttonSkip.UseVisualStyleBackColor = true;
            buttonSkip.Click += ButtonSkipClick;
            // 
            // releaseNote
            // 
            releaseNote.BackColor = System.Drawing.SystemColors.HighlightText;
            releaseNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(releaseNote, "releaseNote");
            releaseNote.Name = "releaseNote";
            releaseNote.ReadOnly = true;
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.Controls.Add(releaseNote);
            panel1.Name = "panel1";
            // 
            // UpdateForm
            // 
            AcceptButton = buttonUpdate;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(pictureBoxIcon);
            Controls.Add(labelReleaseNotes);
            Controls.Add(labelDescription);
            Controls.Add(labelUpdate);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonSkip);
            Controls.Add(buttonRemindLater);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UpdateForm";
            FormClosing += UpdateForm_FormClosing;
            FormClosed += UpdateForm_FormClosed;
            Load += UpdateFormLoad;
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonRemindLater;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonSkip;
        private System.Windows.Forms.Label labelUpdate;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelReleaseNotes;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.RichTextBox releaseNote;
        private System.Windows.Forms.Panel panel1;
    }
}