namespace Lab02
{
    partial class Bai03
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai03));
            this.read = new System.Windows.Forms.Button();
            this.write = new System.Windows.Forms.Button();
            this.calculate = new System.Windows.Forms.Button();
            this.format = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // read
            // 
            this.read.Location = new System.Drawing.Point(173, 22);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(188, 97);
            this.read.TabIndex = 0;
            this.read.Text = "Read Button";
            this.read.UseVisualStyleBackColor = true;
            this.read.Click += new System.EventHandler(this.read_Click);
            // 
            // write
            // 
            this.write.Location = new System.Drawing.Point(452, 22);
            this.write.Name = "write";
            this.write.Size = new System.Drawing.Size(188, 97);
            this.write.TabIndex = 1;
            this.write.Text = "Write Button";
            this.write.UseVisualStyleBackColor = true;
            this.write.Click += new System.EventHandler(this.write_Click);
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(173, 177);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(188, 97);
            this.calculate.TabIndex = 2;
            this.calculate.Text = "Calculate Button";
            this.calculate.UseVisualStyleBackColor = true;
            // 
            // format
            // 
            this.format.Location = new System.Drawing.Point(452, 177);
            this.format.Name = "format";
            this.format.Size = new System.Drawing.Size(188, 97);
            this.format.TabIndex = 3;
            this.format.Text = "Format Button";
            this.format.UseVisualStyleBackColor = true;
            this.format.Click += new System.EventHandler(this.format_Click);
            // 
            // exit
            // 
            this.exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit.BackgroundImage")));
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exit.Location = new System.Drawing.Point(273, 321);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(88, 78);
            this.exit.TabIndex = 4;
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // delete
            // 
            this.delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delete.BackgroundImage")));
            this.delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.delete.Location = new System.Drawing.Point(452, 321);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(88, 78);
            this.delete.TabIndex = 5;
            this.delete.UseVisualStyleBackColor = true;
            // 
            // Bai03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.format);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.write);
            this.Controls.Add(this.read);
            this.Name = "Bai03";
            this.Text = "Bai03";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button read;
        private System.Windows.Forms.Button write;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button format;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button delete;
    }
}