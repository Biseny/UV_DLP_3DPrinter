﻿namespace UV_DLP_3D_Printer.GUI.CustomGUI
{
    partial class ctlScene
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuObject = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmdRemoveObject = new System.Windows.Forms.ToolStripMenuItem();
            this.manipObject = new System.Windows.Forms.FlowLayoutPanel();
            this.ctlTitle1 = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlTitle();
            this.treeScene = new System.Windows.Forms.TreeView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cmdCopy = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.cmdDelete = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.contextMenuObject.SuspendLayout();
            this.manipObject.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuObject
            // 
            this.contextMenuObject.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdRemoveObject});
            this.contextMenuObject.Name = "contextMenuStrip1";
            this.contextMenuObject.Size = new System.Drawing.Size(181, 28);
            // 
            // cmdRemoveObject
            // 
            this.cmdRemoveObject.Name = "cmdRemoveObject";
            this.cmdRemoveObject.Size = new System.Drawing.Size(180, 24);
            this.cmdRemoveObject.Text = "Remove Object";
            this.cmdRemoveObject.Click += new System.EventHandler(this.cmdRemoveObject_Click);
            // 
            // manipObject
            // 
            this.manipObject.BackColor = System.Drawing.Color.Navy;
            this.manipObject.Controls.Add(this.ctlTitle1);
            this.manipObject.Controls.Add(this.treeScene);
            this.manipObject.Controls.Add(this.flowLayoutPanel1);
            this.manipObject.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.manipObject.Location = new System.Drawing.Point(0, 0);
            this.manipObject.Name = "manipObject";
            this.manipObject.Size = new System.Drawing.Size(252, 353);
            this.manipObject.TabIndex = 21;
            // 
            // ctlTitle1
            // 
            this.ctlTitle1.Checked = false;
            this.ctlTitle1.CheckImage = global::UV_DLP_3D_Printer.Properties.Resources.buttStateTrig;
            this.ctlTitle1.Gapx = 0;
            this.ctlTitle1.Gapy = 0;
            this.ctlTitle1.GLBackgroundImage = null;
            this.ctlTitle1.GLVisible = false;
            this.ctlTitle1.GuiAnchor = null;
            this.ctlTitle1.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttTreeview;
            this.ctlTitle1.Location = new System.Drawing.Point(3, 3);
            this.ctlTitle1.Name = "ctlTitle1";
            this.ctlTitle1.Size = new System.Drawing.Size(243, 45);
            this.ctlTitle1.StyleName = null;
            this.ctlTitle1.TabIndex = 2;
            this.ctlTitle1.Text = "Scene";
            this.ctlTitle1.Click += new System.EventHandler(this.ctlTitle1_Click);
            // 
            // treeScene
            // 
            this.treeScene.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.treeScene.BackColor = System.Drawing.Color.RoyalBlue;
            this.treeScene.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeScene.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeScene.ForeColor = System.Drawing.Color.White;
            this.treeScene.Location = new System.Drawing.Point(5, 54);
            this.treeScene.Name = "treeScene";
            this.treeScene.Size = new System.Drawing.Size(222, 256);
            this.treeScene.TabIndex = 1;
            this.treeScene.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeScene_NodeMouseClick);
            // 
            this.treeScene.Location = new System.Drawing.Point(3, 54);
            this.treeScene.Name = "treeScene";
            this.treeScene.Size = new System.Drawing.Size(243, 240);
            this.treeScene.TabIndex = 1;
            this.treeScene.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeScene_NodeMouseClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.cmdCopy);
            this.flowLayoutPanel1.Controls.Add(this.cmdDelete);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 300);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(243, 48);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // cmdCopy
            // 
            this.cmdCopy.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cmdCopy.Checked = false;
            this.cmdCopy.CheckImage = null;
            this.cmdCopy.Gapx = 5;
            this.cmdCopy.Gapy = 5;
            this.cmdCopy.GLBackgroundImage = null;
            this.cmdCopy.GLImage = null;
            this.cmdCopy.GLVisible = false;
            this.cmdCopy.GuiAnchor = null;
            this.cmdCopy.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.cmdCopy.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttPlus;
            this.cmdCopy.Location = new System.Drawing.Point(3, 3);
            this.cmdCopy.Name = "cmdCopy";
            this.cmdCopy.Size = new System.Drawing.Size(40, 40);
            this.cmdCopy.StyleName = null;
            this.cmdCopy.TabIndex = 65;
            this.cmdCopy.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.cmdCopy.Click += new System.EventHandler(this.cmdCopy_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cmdDelete.Checked = false;
            this.cmdDelete.CheckImage = null;
            this.cmdDelete.Gapx = 5;
            this.cmdDelete.Gapy = 5;
            this.cmdDelete.GLBackgroundImage = null;
            this.cmdDelete.GLImage = null;
            this.cmdDelete.GLVisible = false;
            this.cmdDelete.GuiAnchor = null;
            this.cmdDelete.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.cmdDelete.Image = global::UV_DLP_3D_Printer.Properties.Resources.butMinus;
            this.cmdDelete.Location = new System.Drawing.Point(49, 3);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(40, 40);
            this.cmdDelete.StyleName = null;
            this.cmdDelete.TabIndex = 66;
            this.cmdDelete.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // ctlScene
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.manipObject);
            this.Name = "ctlScene";
            this.Size = new System.Drawing.Size(260, 362);
            this.Resize += new System.EventHandler(this.ctlScene_Resize);
            this.contextMenuObject.ResumeLayout(false);
            this.manipObject.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel manipObject;
        private System.Windows.Forms.TreeView treeScene;
        private System.Windows.Forms.ContextMenuStrip contextMenuObject;
        private System.Windows.Forms.ToolStripMenuItem cmdRemoveObject;
        private ctlTitle ctlTitle1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ctlImageButton cmdCopy;
        private ctlImageButton cmdDelete;

    }
}
