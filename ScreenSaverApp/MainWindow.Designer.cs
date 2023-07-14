
namespace ScreenSaverApp
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.btnDisplay1 = new System.Windows.Forms.Button();
            this.btnDisplay2 = new System.Windows.Forms.Button();
            this.niIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ctxNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miDisplay1 = new System.Windows.Forms.ToolStripMenuItem();
            this.miDisplay2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxNotify.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDisplay1
            // 
            this.btnDisplay1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDisplay1.Location = new System.Drawing.Point(55, 100);
            this.btnDisplay1.Name = "btnDisplay1";
            this.btnDisplay1.Size = new System.Drawing.Size(129, 52);
            this.btnDisplay1.TabIndex = 0;
            this.btnDisplay1.Text = "Display 1";
            this.btnDisplay1.UseVisualStyleBackColor = true;
            // 
            // btnDisplay2
            // 
            this.btnDisplay2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDisplay2.Location = new System.Drawing.Point(190, 100);
            this.btnDisplay2.Name = "btnDisplay2";
            this.btnDisplay2.Size = new System.Drawing.Size(129, 52);
            this.btnDisplay2.TabIndex = 1;
            this.btnDisplay2.Text = "Display 2";
            this.btnDisplay2.UseVisualStyleBackColor = true;
            // 
            // niIcon
            // 
            this.niIcon.ContextMenuStrip = this.ctxNotify;
            this.niIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("niIcon.Icon")));
            this.niIcon.Text = "Screen Saver";
            this.niIcon.Visible = true;
            // 
            // ctxNotify
            // 
            this.ctxNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miDisplay1,
            this.miDisplay2,
            this.toolStripMenuItem1,
            this.miExit});
            this.ctxNotify.Name = "ctxNotify";
            this.ctxNotify.Size = new System.Drawing.Size(122, 76);
            // 
            // miDisplay1
            // 
            this.miDisplay1.Name = "miDisplay1";
            this.miDisplay1.Size = new System.Drawing.Size(121, 22);
            this.miDisplay1.Text = "Display 1";
            // 
            // miDisplay2
            // 
            this.miDisplay2.Name = "miDisplay2";
            this.miDisplay2.Size = new System.Drawing.Size(121, 22);
            this.miDisplay2.Text = "Display 2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(118, 6);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(121, 22);
            this.miExit.Text = "Exit";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 252);
            this.Controls.Add(this.btnDisplay2);
            this.Controls.Add(this.btnDisplay1);
            this.Name = "MainWindow";
            this.Text = "Screen Saver";
            this.ctxNotify.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDisplay1;
        private System.Windows.Forms.Button btnDisplay2;
        private System.Windows.Forms.NotifyIcon niIcon;
        private System.Windows.Forms.ContextMenuStrip ctxNotify;
        private System.Windows.Forms.ToolStripMenuItem miDisplay1;
        private System.Windows.Forms.ToolStripMenuItem miDisplay2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem miExit;
    }
}

