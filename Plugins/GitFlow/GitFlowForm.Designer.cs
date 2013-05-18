﻿namespace GitFlow
{
    partial class GitFlowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GitFlowForm));
            this.btnInit = new System.Windows.Forms.Button();
            this.txtBranchName = new System.Windows.Forms.TextBox();
            this.btnCreateBranch = new System.Windows.Forms.Button();
            this.cbBranches = new System.Windows.Forms.ComboBox();
            this.btnFinish = new System.Windows.Forms.Button();
            this.gbManage = new System.Windows.Forms.GroupBox();
            this.pnlManageBranch = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlPull = new System.Windows.Forms.Panel();
            this.cbRemote = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPull = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPrefixManage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPublish = new System.Windows.Forms.Button();
            this.cbManageType = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblPrefixName = new System.Windows.Forms.Label();
            this.gbStart = new System.Windows.Forms.GroupBox();
            this.pnlBasedOn = new System.Windows.Forms.Panel();
            this.cbBaseBranch = new System.Windows.Forms.ComboBox();
            this.cbBasedOn = new System.Windows.Forms.CheckBox();
            this.lblDebug = new System.Windows.Forms.Label();
            this.lnkGitFlow = new System.Windows.Forms.LinkLabel();
            this.pbResultCommand = new System.Windows.Forms.PictureBox();
            this.gbManage.SuspendLayout();
            this.pnlManageBranch.SuspendLayout();
            this.pnlPull.SuspendLayout();
            this.gbStart.SuspendLayout();
            this.pnlBasedOn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResultCommand)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(284, 12);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(83, 23);
            this.btnInit.TabIndex = 0;
            this.btnInit.Text = "Init GitFlow";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // txtBranchName
            // 
            this.txtBranchName.Location = new System.Drawing.Point(163, 25);
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.Size = new System.Drawing.Size(374, 20);
            this.txtBranchName.TabIndex = 2;
            // 
            // btnCreateBranch
            // 
            this.btnCreateBranch.Location = new System.Drawing.Point(542, 23);
            this.btnCreateBranch.Name = "btnCreateBranch";
            this.btnCreateBranch.Size = new System.Drawing.Size(81, 23);
            this.btnCreateBranch.TabIndex = 0;
            this.btnCreateBranch.Text = "Start!";
            this.btnCreateBranch.UseVisualStyleBackColor = true;
            this.btnCreateBranch.Click += new System.EventHandler(this.btnStartBranch_Click);
            // 
            // cbBranches
            // 
            this.cbBranches.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBranches.FormattingEnabled = true;
            this.cbBranches.Location = new System.Drawing.Point(151, 8);
            this.cbBranches.Name = "cbBranches";
            this.cbBranches.Size = new System.Drawing.Size(374, 21);
            this.cbBranches.TabIndex = 3;
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(490, 72);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(82, 23);
            this.btnFinish.TabIndex = 0;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // gbManage
            // 
            this.gbManage.Controls.Add(this.pnlManageBranch);
            this.gbManage.Controls.Add(this.cbManageType);
            this.gbManage.Location = new System.Drawing.Point(13, 149);
            this.gbManage.Name = "gbManage";
            this.gbManage.Size = new System.Drawing.Size(628, 162);
            this.gbManage.TabIndex = 6;
            this.gbManage.TabStop = false;
            this.gbManage.Text = "Manage existing branches:";
            // 
            // pnlManageBranch
            // 
            this.pnlManageBranch.Controls.Add(this.panel2);
            this.pnlManageBranch.Controls.Add(this.pnlPull);
            this.pnlManageBranch.Controls.Add(this.panel1);
            this.pnlManageBranch.Controls.Add(this.lblPrefixManage);
            this.pnlManageBranch.Controls.Add(this.label1);
            this.pnlManageBranch.Controls.Add(this.cbBranches);
            this.pnlManageBranch.Controls.Add(this.btnPublish);
            this.pnlManageBranch.Controls.Add(this.btnFinish);
            this.pnlManageBranch.Location = new System.Drawing.Point(10, 30);
            this.pnlManageBranch.Name = "pnlManageBranch";
            this.pnlManageBranch.Size = new System.Drawing.Size(610, 131);
            this.pnlManageBranch.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(448, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 70);
            this.panel2.TabIndex = 5;
            // 
            // pnlPull
            // 
            this.pnlPull.Controls.Add(this.cbRemote);
            this.pnlPull.Controls.Add(this.label9);
            this.pnlPull.Controls.Add(this.btnPull);
            this.pnlPull.Location = new System.Drawing.Point(168, 40);
            this.pnlPull.Name = "pnlPull";
            this.pnlPull.Size = new System.Drawing.Size(274, 84);
            this.pnlPull.TabIndex = 6;
            // 
            // cbRemote
            // 
            this.cbRemote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRemote.FormattingEnabled = true;
            this.cbRemote.Location = new System.Drawing.Point(12, 24);
            this.cbRemote.Name = "cbRemote";
            this.cbRemote.Size = new System.Drawing.Size(239, 21);
            this.cbRemote.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(80, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Remote to pull from :";
            // 
            // btnPull
            // 
            this.btnPull.Location = new System.Drawing.Point(96, 47);
            this.btnPull.Name = "btnPull";
            this.btnPull.Size = new System.Drawing.Size(83, 23);
            this.btnPull.TabIndex = 0;
            this.btnPull.Text = "Pull";
            this.btnPull.UseVisualStyleBackColor = true;
            this.btnPull.Click += new System.EventHandler(this.btnPull_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(151, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 70);
            this.panel1.TabIndex = 4;
            // 
            // lblPrefixManage
            // 
            this.lblPrefixManage.AutoSize = true;
            this.lblPrefixManage.Location = new System.Drawing.Point(104, 11);
            this.lblPrefixManage.Name = "lblPrefixManage";
            this.lblPrefixManage.Size = new System.Drawing.Size(43, 13);
            this.lblPrefixManage.TabIndex = 1;
            this.lblPrefixManage.Text = "[prefix]/";
            this.lblPrefixManage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "branch:";
            // 
            // btnPublish
            // 
            this.btnPublish.Location = new System.Drawing.Point(31, 72);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(81, 23);
            this.btnPublish.TabIndex = 0;
            this.btnPublish.Text = "Publish";
            this.btnPublish.UseVisualStyleBackColor = true;
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // cbManageType
            // 
            this.cbManageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbManageType.FormattingEnabled = true;
            this.cbManageType.Location = new System.Drawing.Point(139, 0);
            this.cbManageType.Name = "cbManageType";
            this.cbManageType.Size = new System.Drawing.Size(128, 21);
            this.cbManageType.TabIndex = 3;
            this.cbManageType.SelectedValueChanged += new System.EventHandler(this.cbManageType_SelectedValueChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(284, 318);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(74, 0);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(128, 21);
            this.cbType.TabIndex = 3;
            this.cbType.SelectedValueChanged += new System.EventHandler(this.cbType_SelectedValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Expected name:";
            // 
            // lblPrefixName
            // 
            this.lblPrefixName.AutoSize = true;
            this.lblPrefixName.Location = new System.Drawing.Point(119, 28);
            this.lblPrefixName.Name = "lblPrefixName";
            this.lblPrefixName.Size = new System.Drawing.Size(43, 13);
            this.lblPrefixName.TabIndex = 1;
            this.lblPrefixName.Text = "[prefix]/";
            this.lblPrefixName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gbStart
            // 
            this.gbStart.Controls.Add(this.pnlBasedOn);
            this.gbStart.Controls.Add(this.cbType);
            this.gbStart.Controls.Add(this.txtBranchName);
            this.gbStart.Controls.Add(this.lblPrefixName);
            this.gbStart.Controls.Add(this.label10);
            this.gbStart.Controls.Add(this.btnCreateBranch);
            this.gbStart.Location = new System.Drawing.Point(12, 41);
            this.gbStart.Name = "gbStart";
            this.gbStart.Size = new System.Drawing.Size(629, 100);
            this.gbStart.TabIndex = 8;
            this.gbStart.TabStop = false;
            this.gbStart.Text = "Start branch:";
            // 
            // pnlBasedOn
            // 
            this.pnlBasedOn.Controls.Add(this.cbBaseBranch);
            this.pnlBasedOn.Controls.Add(this.cbBasedOn);
            this.pnlBasedOn.Location = new System.Drawing.Point(119, 51);
            this.pnlBasedOn.Name = "pnlBasedOn";
            this.pnlBasedOn.Size = new System.Drawing.Size(501, 37);
            this.pnlBasedOn.TabIndex = 4;
            // 
            // cbBaseBranch
            // 
            this.cbBaseBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBaseBranch.FormattingEnabled = true;
            this.cbBaseBranch.Location = new System.Drawing.Point(78, 8);
            this.cbBaseBranch.Name = "cbBaseBranch";
            this.cbBaseBranch.Size = new System.Drawing.Size(340, 21);
            this.cbBaseBranch.TabIndex = 3;
            // 
            // cbBasedOn
            // 
            this.cbBasedOn.AutoSize = true;
            this.cbBasedOn.Location = new System.Drawing.Point(3, 11);
            this.cbBasedOn.Name = "cbBasedOn";
            this.cbBasedOn.Size = new System.Drawing.Size(73, 17);
            this.cbBasedOn.TabIndex = 0;
            this.cbBasedOn.Text = "based on:";
            this.cbBasedOn.UseVisualStyleBackColor = true;
            this.cbBasedOn.CheckedChanged += new System.EventHandler(this.cbBasedOn_CheckedChanged);
            // 
            // lblDebug
            // 
            this.lblDebug.AutoSize = true;
            this.lblDebug.Location = new System.Drawing.Point(21, 338);
            this.lblDebug.Name = "lblDebug";
            this.lblDebug.Size = new System.Drawing.Size(238, 13);
            this.lblDebug.TabIndex = 7;
            this.lblDebug.Text = "                                                                             ";
            // 
            // lnkGitFlow
            // 
            this.lnkGitFlow.AutoSize = true;
            this.lnkGitFlow.Location = new System.Drawing.Point(559, 17);
            this.lnkGitFlow.Name = "lnkGitFlow";
            this.lnkGitFlow.Size = new System.Drawing.Size(73, 13);
            this.lnkGitFlow.TabIndex = 9;
            this.lnkGitFlow.TabStop = true;
            this.lnkGitFlow.Text = "About GitFlow";
            this.lnkGitFlow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGitFlow_LinkClicked);
            // 
            // pbResultCommand
            // 
            this.pbResultCommand.Location = new System.Drawing.Point(12, 10);
            this.pbResultCommand.Name = "pbResultCommand";
            this.pbResultCommand.Size = new System.Drawing.Size(25, 25);
            this.pbResultCommand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResultCommand.TabIndex = 10;
            this.pbResultCommand.TabStop = false;
            // 
            // GitFlowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(653, 348);
            this.Controls.Add(this.pbResultCommand);
            this.Controls.Add(this.lnkGitFlow);
            this.Controls.Add(this.gbStart);
            this.Controls.Add(this.lblDebug);
            this.Controls.Add(this.gbManage);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnInit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GitFlowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GitFlow";
            this.gbManage.ResumeLayout(false);
            this.pnlManageBranch.ResumeLayout(false);
            this.pnlManageBranch.PerformLayout();
            this.pnlPull.ResumeLayout(false);
            this.pnlPull.PerformLayout();
            this.gbStart.ResumeLayout(false);
            this.gbStart.PerformLayout();
            this.pnlBasedOn.ResumeLayout(false);
            this.pnlBasedOn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResultCommand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.TextBox txtBranchName;
        private System.Windows.Forms.Button btnCreateBranch;
        private System.Windows.Forms.ComboBox cbBranches;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.GroupBox gbManage;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cbRemote;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPull;
        private System.Windows.Forms.Button btnPublish;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblPrefixName;
        private System.Windows.Forms.GroupBox gbStart;
        private System.Windows.Forms.ComboBox cbManageType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrefixManage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlPull;
        private System.Windows.Forms.Panel pnlManageBranch;
        private System.Windows.Forms.Panel pnlBasedOn;
        private System.Windows.Forms.ComboBox cbBaseBranch;
        private System.Windows.Forms.CheckBox cbBasedOn;
        private System.Windows.Forms.Label lblDebug;
        private System.Windows.Forms.LinkLabel lnkGitFlow;
        private System.Windows.Forms.PictureBox pbResultCommand;
    }
}