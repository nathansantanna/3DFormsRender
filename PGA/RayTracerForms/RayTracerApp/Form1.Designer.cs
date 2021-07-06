using System.ComponentModel;
using System.Windows.Forms;

namespace RayTracerApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbScene = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sceneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marbleSpheresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.woodenFloorAndStoneWallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reflectiveShereOnChessboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.woodenBoxAndMarbleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomMarblesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renderNowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPhongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.castShadowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showReflectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showRefractionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCellShadingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbSecondaryScene = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPhongHighlight = new System.Windows.Forms.CheckBox();
            this.cbCastShadow = new System.Windows.Forms.CheckBox();
            this.cbShowReflections = new System.Windows.Forms.CheckBox();
            this.cbShowRefractions = new System.Windows.Forms.CheckBox();
            this.cbCellShading = new System.Windows.Forms.CheckBox();
            this.cbApplySobell = new System.Windows.Forms.CheckBox();
            this.cbApplyBlur = new System.Windows.Forms.CheckBox();
            this.cbRenderDiffuse = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbApplyHDR = new System.Windows.Forms.CheckBox();
            this.cbSecondaryPanel = new System.Windows.Forms.CheckBox();
            this.cbMainPanel = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbDetectBorders = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScene)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSecondaryScene)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(1143, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 22);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pbScene
            // 
            this.pbScene.AccessibleDescription = "";
            this.pbScene.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbScene.Location = new System.Drawing.Point(15, 55);
            this.pbScene.Name = "pbScene";
            this.pbScene.Size = new System.Drawing.Size(445, 420);
            this.pbScene.TabIndex = 2;
            this.pbScene.TabStop = false;
            this.pbScene.Click += new System.EventHandler(this.pbScene_Click);
            this.pbScene.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbScene_MouseDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1168, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sceneToolStripMenuItem,
            this.renderNowToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // sceneToolStripMenuItem
            // 
            this.sceneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marbleSpheresToolStripMenuItem,
            this.woodenFloorAndStoneWallToolStripMenuItem,
            this.reflectiveShereOnChessboardToolStripMenuItem,
            this.woodenBoxAndMarbleToolStripMenuItem,
            this.randomMarblesToolStripMenuItem});
            this.sceneToolStripMenuItem.Name = "sceneToolStripMenuItem";
            this.sceneToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.sceneToolStripMenuItem.Text = "&Scene";
            // 
            // marbleSpheresToolStripMenuItem
            // 
            this.marbleSpheresToolStripMenuItem.Checked = true;
            this.marbleSpheresToolStripMenuItem.CheckOnClick = true;
            this.marbleSpheresToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.marbleSpheresToolStripMenuItem.Name = "marbleSpheresToolStripMenuItem";
            this.marbleSpheresToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.marbleSpheresToolStripMenuItem.Text = "Two marbles on chessboard";
            this.marbleSpheresToolStripMenuItem.Click += new System.EventHandler(this.marbleSpheresToolStripMenuItem_Click);
            // 
            // woodenFloorAndStoneWallToolStripMenuItem
            // 
            this.woodenFloorAndStoneWallToolStripMenuItem.Name = "woodenFloorAndStoneWallToolStripMenuItem";
            this.woodenFloorAndStoneWallToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.woodenFloorAndStoneWallToolStripMenuItem.Text = "Marble on wooden floor and stone wall";
            this.woodenFloorAndStoneWallToolStripMenuItem.Click += new System.EventHandler(this.woodenFloorAndStoneWallToolStripMenuItem_Click);
            // 
            // reflectiveShereOnChessboardToolStripMenuItem
            // 
            this.reflectiveShereOnChessboardToolStripMenuItem.Name = "reflectiveShereOnChessboardToolStripMenuItem";
            this.reflectiveShereOnChessboardToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.reflectiveShereOnChessboardToolStripMenuItem.Text = "Reflective shere on chessboard";
            this.reflectiveShereOnChessboardToolStripMenuItem.Click += new System.EventHandler(this.reflectiveShereOnChessboardToolStripMenuItem_Click);
            // 
            // woodenBoxAndMarbleToolStripMenuItem
            // 
            this.woodenBoxAndMarbleToolStripMenuItem.Name = "woodenBoxAndMarbleToolStripMenuItem";
            this.woodenBoxAndMarbleToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.woodenBoxAndMarbleToolStripMenuItem.Text = "Wooden sphere and marble";
            this.woodenBoxAndMarbleToolStripMenuItem.Click += new System.EventHandler(this.woodenBoxAndMarbleToolStripMenuItem_Click);
            // 
            // randomMarblesToolStripMenuItem
            // 
            this.randomMarblesToolStripMenuItem.Name = "randomMarblesToolStripMenuItem";
            this.randomMarblesToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.randomMarblesToolStripMenuItem.Text = "Random marbles";
            this.randomMarblesToolStripMenuItem.Click += new System.EventHandler(this.randomMarblesToolStripMenuItem_Click);
            // 
            // renderNowToolStripMenuItem
            // 
            this.renderNowToolStripMenuItem.Name = "renderNowToolStripMenuItem";
            this.renderNowToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.renderNowToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.renderNowToolStripMenuItem.Text = "&ImageProcess";
            this.renderNowToolStripMenuItem.Click += new System.EventHandler(this.renderNowToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPhongToolStripMenuItem,
            this.castShadowsToolStripMenuItem,
            this.showReflectionsToolStripMenuItem,
            this.showRefractionsToolStripMenuItem,
            this.showCellShadingToolStripMenuItem,
            this.filtersToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "&Settings";
            // 
            // showPhongToolStripMenuItem
            // 
            this.showPhongToolStripMenuItem.Checked = true;
            this.showPhongToolStripMenuItem.CheckOnClick = true;
            this.showPhongToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showPhongToolStripMenuItem.Name = "showPhongToolStripMenuItem";
            this.showPhongToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.showPhongToolStripMenuItem.Text = "Show Phong Highlights";
            // 
            // castShadowsToolStripMenuItem
            // 
            this.castShadowsToolStripMenuItem.Checked = true;
            this.castShadowsToolStripMenuItem.CheckOnClick = true;
            this.castShadowsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.castShadowsToolStripMenuItem.Name = "castShadowsToolStripMenuItem";
            this.castShadowsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.castShadowsToolStripMenuItem.Text = "Cast Shadows";
            // 
            // showReflectionsToolStripMenuItem
            // 
            this.showReflectionsToolStripMenuItem.Checked = true;
            this.showReflectionsToolStripMenuItem.CheckOnClick = true;
            this.showReflectionsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showReflectionsToolStripMenuItem.Name = "showReflectionsToolStripMenuItem";
            this.showReflectionsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.showReflectionsToolStripMenuItem.Text = "Show Reflections";
            // 
            // showRefractionsToolStripMenuItem
            // 
            this.showRefractionsToolStripMenuItem.Checked = true;
            this.showRefractionsToolStripMenuItem.CheckOnClick = true;
            this.showRefractionsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showRefractionsToolStripMenuItem.Name = "showRefractionsToolStripMenuItem";
            this.showRefractionsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.showRefractionsToolStripMenuItem.Text = "Show Refractions";
            // 
            // showCellShadingToolStripMenuItem
            // 
            this.showCellShadingToolStripMenuItem.Checked = true;
            this.showCellShadingToolStripMenuItem.CheckOnClick = true;
            this.showCellShadingToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showCellShadingToolStripMenuItem.Name = "showCellShadingToolStripMenuItem";
            this.showCellShadingToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.showCellShadingToolStripMenuItem.Text = "Show CellShading";
            this.showCellShadingToolStripMenuItem.Click += new System.EventHandler(this.cellShadingToolStripMenuItem_Click);
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blurToolStripMenuItem});
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.filtersToolStripMenuItem.Text = "Filters";
            // 
            // blurToolStripMenuItem
            // 
            this.blurToolStripMenuItem.CheckOnClick = true;
            this.blurToolStripMenuItem.Name = "blurToolStripMenuItem";
            this.blurToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.blurToolStripMenuItem.Text = "Blur";
            this.blurToolStripMenuItem.Click += new System.EventHandler(this.blurToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 478);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1168, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // pbSecondaryScene
            // 
            this.pbSecondaryScene.AccessibleDescription = "";
            this.pbSecondaryScene.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbSecondaryScene.Location = new System.Drawing.Point(466, 55);
            this.pbSecondaryScene.Name = "pbSecondaryScene";
            this.pbSecondaryScene.Size = new System.Drawing.Size(420, 420);
            this.pbSecondaryScene.TabIndex = 8;
            this.pbSecondaryScene.TabStop = false;
            this.pbSecondaryScene.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(903, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "ImageProcess Options";
            // 
            // cbPhongHighlight
            // 
            this.cbPhongHighlight.AutoSize = true;
            this.cbPhongHighlight.Location = new System.Drawing.Point(3, 29);
            this.cbPhongHighlight.Name = "cbPhongHighlight";
            this.cbPhongHighlight.Size = new System.Drawing.Size(105, 17);
            this.cbPhongHighlight.TabIndex = 14;
            this.cbPhongHighlight.Text = "Phong HighLight";
            this.cbPhongHighlight.UseVisualStyleBackColor = true;
            // 
            // cbCastShadow
            // 
            this.cbCastShadow.AutoSize = true;
            this.cbCastShadow.Checked = true;
            this.cbCastShadow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCastShadow.Location = new System.Drawing.Point(3, 52);
            this.cbCastShadow.Name = "cbCastShadow";
            this.cbCastShadow.Size = new System.Drawing.Size(94, 17);
            this.cbCastShadow.TabIndex = 15;
            this.cbCastShadow.Text = "Cast Shadows";
            this.cbCastShadow.UseVisualStyleBackColor = true;
            // 
            // cbShowReflections
            // 
            this.cbShowReflections.AutoSize = true;
            this.cbShowReflections.Checked = true;
            this.cbShowReflections.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowReflections.Location = new System.Drawing.Point(3, 75);
            this.cbShowReflections.Name = "cbShowReflections";
            this.cbShowReflections.Size = new System.Drawing.Size(109, 17);
            this.cbShowReflections.TabIndex = 16;
            this.cbShowReflections.Text = "Show Reflections";
            this.cbShowReflections.UseVisualStyleBackColor = true;
            // 
            // cbShowRefractions
            // 
            this.cbShowRefractions.AutoSize = true;
            this.cbShowRefractions.Checked = true;
            this.cbShowRefractions.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowRefractions.Location = new System.Drawing.Point(3, 98);
            this.cbShowRefractions.Name = "cbShowRefractions";
            this.cbShowRefractions.Size = new System.Drawing.Size(110, 17);
            this.cbShowRefractions.TabIndex = 17;
            this.cbShowRefractions.Text = "Show Refractions";
            this.cbShowRefractions.UseVisualStyleBackColor = true;
            // 
            // cbCellShading
            // 
            this.cbCellShading.AutoSize = true;
            this.cbCellShading.Location = new System.Drawing.Point(3, 121);
            this.cbCellShading.Name = "cbCellShading";
            this.cbCellShading.Size = new System.Drawing.Size(111, 17);
            this.cbCellShading.TabIndex = 18;
            this.cbCellShading.Text = "Apply CellShading";
            this.cbCellShading.UseVisualStyleBackColor = true;
            // 
            // cbApplySobell
            // 
            this.cbApplySobell.AutoSize = true;
            this.cbApplySobell.Location = new System.Drawing.Point(3, 144);
            this.cbApplySobell.Name = "cbApplySobell";
            this.cbApplySobell.Size = new System.Drawing.Size(80, 17);
            this.cbApplySobell.TabIndex = 19;
            this.cbApplySobell.Text = "Apply sobel";
            this.cbApplySobell.UseVisualStyleBackColor = true;
            // 
            // cbApplyBlur
            // 
            this.cbApplyBlur.AutoSize = true;
            this.cbApplyBlur.Location = new System.Drawing.Point(3, 167);
            this.cbApplyBlur.Name = "cbApplyBlur";
            this.cbApplyBlur.Size = new System.Drawing.Size(73, 17);
            this.cbApplyBlur.TabIndex = 20;
            this.cbApplyBlur.Text = "Apply Blur";
            this.cbApplyBlur.UseVisualStyleBackColor = true;
            // 
            // cbRenderDiffuse
            // 
            this.cbRenderDiffuse.AutoSize = true;
            this.cbRenderDiffuse.Checked = true;
            this.cbRenderDiffuse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRenderDiffuse.Location = new System.Drawing.Point(3, 6);
            this.cbRenderDiffuse.Name = "cbRenderDiffuse";
            this.cbRenderDiffuse.Size = new System.Drawing.Size(94, 17);
            this.cbRenderDiffuse.TabIndex = 21;
            this.cbRenderDiffuse.Text = "RenderDiffuse";
            this.cbRenderDiffuse.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbDetectBorders);
            this.panel1.Controls.Add(this.cbApplyHDR);
            this.panel1.Controls.Add(this.cbPhongHighlight);
            this.panel1.Controls.Add(this.cbRenderDiffuse);
            this.panel1.Controls.Add(this.cbCastShadow);
            this.panel1.Controls.Add(this.cbApplyBlur);
            this.panel1.Controls.Add(this.cbShowReflections);
            this.panel1.Controls.Add(this.cbApplySobell);
            this.panel1.Controls.Add(this.cbShowRefractions);
            this.panel1.Controls.Add(this.cbCellShading);
            this.panel1.Location = new System.Drawing.Point(906, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 241);
            this.panel1.TabIndex = 0;
            // 
            // cbApplyHDR
            // 
            this.cbApplyHDR.AutoSize = true;
            this.cbApplyHDR.Location = new System.Drawing.Point(3, 190);
            this.cbApplyHDR.Name = "cbApplyHDR";
            this.cbApplyHDR.Size = new System.Drawing.Size(79, 17);
            this.cbApplyHDR.TabIndex = 22;
            this.cbApplyHDR.Text = "Apply HDR";
            this.cbApplyHDR.UseVisualStyleBackColor = true;
            this.cbApplyHDR.CheckedChanged += new System.EventHandler(this.cbApplyHDR_CheckedChanged);
            // 
            // cbSecondaryPanel
            // 
            this.cbSecondaryPanel.AutoSize = true;
            this.cbSecondaryPanel.Location = new System.Drawing.Point(3, 26);
            this.cbSecondaryPanel.Name = "cbSecondaryPanel";
            this.cbSecondaryPanel.Size = new System.Drawing.Size(107, 17);
            this.cbSecondaryPanel.TabIndex = 14;
            this.cbSecondaryPanel.Text = "Secondary Panel";
            this.cbSecondaryPanel.UseVisualStyleBackColor = true;
            // 
            // cbMainPanel
            // 
            this.cbMainPanel.AutoSize = true;
            this.cbMainPanel.Checked = true;
            this.cbMainPanel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMainPanel.Location = new System.Drawing.Point(3, 3);
            this.cbMainPanel.Name = "cbMainPanel";
            this.cbMainPanel.Size = new System.Drawing.Size(79, 17);
            this.cbMainPanel.TabIndex = 15;
            this.cbMainPanel.Text = "Main Panel";
            this.cbMainPanel.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbMainPanel);
            this.panel2.Controls.Add(this.cbSecondaryPanel);
            this.panel2.Location = new System.Drawing.Point(903, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(117, 60);
            this.panel2.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(903, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Draw On";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Main Panel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(463, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Scondary Panel";
            // 
            // cbDetectBorders
            // 
            this.cbDetectBorders.AutoSize = true;
            this.cbDetectBorders.Checked = true;
            this.cbDetectBorders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDetectBorders.Location = new System.Drawing.Point(4, 213);
            this.cbDetectBorders.Name = "cbDetectBorders";
            this.cbDetectBorders.Size = new System.Drawing.Size(97, 17);
            this.cbDetectBorders.TabIndex = 23;
            this.cbDetectBorders.Text = "Detect Borders";
            this.cbDetectBorders.UseVisualStyleBackColor = true;
            this.cbDetectBorders.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 500);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbSecondaryScene);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pbScene);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Raytracer.Net";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScene)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSecondaryScene)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pbScene;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem sceneToolStripMenuItem;
        private ToolStripMenuItem marbleSpheresToolStripMenuItem;
        private ToolStripMenuItem woodenFloorAndStoneWallToolStripMenuItem;
        private ToolStripMenuItem renderNowToolStripMenuItem;
        private ToolStripMenuItem randomMarblesToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem castShadowsToolStripMenuItem;
        private ToolStripMenuItem showReflectionsToolStripMenuItem;
        private ToolStripMenuItem showRefractionsToolStripMenuItem;
        private ToolStripMenuItem showPhongToolStripMenuItem;
        private ToolStripMenuItem reflectiveShereOnChessboardToolStripMenuItem;
        private ToolStripMenuItem woodenBoxAndMarbleToolStripMenuItem;
        private ToolStripMenuItem filtersToolStripMenuItem;
        private ToolStripMenuItem blurToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripMenuItem showCellShadingToolStripMenuItem;
        private PictureBox pbSecondaryScene;
        private Label label2;
        private CheckBox cbPhongHighlight;
        private CheckBox cbCastShadow;
        private CheckBox cbShowReflections;
        private CheckBox cbShowRefractions;
        private CheckBox cbCellShading;
        private CheckBox cbApplySobell;
        private CheckBox cbApplyBlur;
        private CheckBox cbRenderDiffuse;
        private Panel panel1;
        private CheckBox cbSecondaryPanel;
        private CheckBox cbMainPanel;
        private Panel panel2;
        private Label label1;
        private Label label3;
        private Label label4;
        private CheckBox cbApplyHDR;
        private CheckBox cbDetectBorders;
    }
}

