namespace Parduotuve_povbuk
{
    partial class Form4
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
            this.duomenuBazeDataSet = new Parduotuve_povbuk.DuomenuBazeDataSet();
            this.uzsakymaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uzsakymaiTableAdapter = new Parduotuve_povbuk.DuomenuBazeDataSetTableAdapters.UzsakymaiTableAdapter();
            this.tableAdapterManager = new Parduotuve_povbuk.DuomenuBazeDataSetTableAdapters.TableAdapterManager();
            this.uzsakymaiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagal_Uzsakymo_IDToolStrip = new System.Windows.Forms.ToolStrip();
            this.idToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.idToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.pagal_Uzsakymo_IDToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pagal_Vartotojo_IDToolStrip = new System.Windows.Forms.ToolStrip();
            this.idToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.idToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.pagal_Vartotojo_IDToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.duomenuBazeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uzsakymaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uzsakymaiDataGridView)).BeginInit();
            this.pagal_Uzsakymo_IDToolStrip.SuspendLayout();
            this.pagal_Vartotojo_IDToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // duomenuBazeDataSet
            // 
            this.duomenuBazeDataSet.DataSetName = "DuomenuBazeDataSet";
            this.duomenuBazeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uzsakymaiBindingSource
            // 
            this.uzsakymaiBindingSource.DataMember = "Uzsakymai";
            this.uzsakymaiBindingSource.DataSource = this.duomenuBazeDataSet;
            // 
            // uzsakymaiTableAdapter
            // 
            this.uzsakymaiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.IrasaiTableAdapter = null;
            this.tableAdapterManager.PrekesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Parduotuve_povbuk.DuomenuBazeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UzsakymaiTableAdapter = this.uzsakymaiTableAdapter;
            this.tableAdapterManager.VartotojaiTableAdapter = null;
            // 
            // uzsakymaiDataGridView
            // 
            this.uzsakymaiDataGridView.AutoGenerateColumns = false;
            this.uzsakymaiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uzsakymaiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.uzsakymaiDataGridView.DataSource = this.uzsakymaiBindingSource;
            this.uzsakymaiDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uzsakymaiDataGridView.Location = new System.Drawing.Point(0, 54);
            this.uzsakymaiDataGridView.Name = "uzsakymaiDataGridView";
            this.uzsakymaiDataGridView.RowTemplate.Height = 24;
            this.uzsakymaiDataGridView.Size = new System.Drawing.Size(737, 388);
            this.uzsakymaiDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Uzsakymo ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Uzsakymo ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Vartotojo ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "Vartotojo ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Kaina";
            this.dataGridViewTextBoxColumn3.HeaderText = "Kaina";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Adresas";
            this.dataGridViewTextBoxColumn4.HeaderText = "Adresas";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Atsiskaitymo tipas";
            this.dataGridViewTextBoxColumn5.HeaderText = "Atsiskaitymo tipas";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // pagal_Uzsakymo_IDToolStrip
            // 
            this.pagal_Uzsakymo_IDToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.pagal_Uzsakymo_IDToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idToolStripLabel,
            this.idToolStripTextBox,
            this.pagal_Uzsakymo_IDToolStripButton});
            this.pagal_Uzsakymo_IDToolStrip.Location = new System.Drawing.Point(0, 27);
            this.pagal_Uzsakymo_IDToolStrip.Name = "pagal_Uzsakymo_IDToolStrip";
            this.pagal_Uzsakymo_IDToolStrip.Size = new System.Drawing.Size(737, 27);
            this.pagal_Uzsakymo_IDToolStrip.TabIndex = 2;
            this.pagal_Uzsakymo_IDToolStrip.Text = "pagal_Uzsakymo_IDToolStrip";
            // 
            // idToolStripLabel
            // 
            this.idToolStripLabel.Name = "idToolStripLabel";
            this.idToolStripLabel.Size = new System.Drawing.Size(25, 24);
            this.idToolStripLabel.Text = "id:";
            // 
            // idToolStripTextBox
            // 
            this.idToolStripTextBox.Name = "idToolStripTextBox";
            this.idToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // pagal_Uzsakymo_IDToolStripButton
            // 
            this.pagal_Uzsakymo_IDToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.pagal_Uzsakymo_IDToolStripButton.Name = "pagal_Uzsakymo_IDToolStripButton";
            this.pagal_Uzsakymo_IDToolStripButton.Size = new System.Drawing.Size(145, 24);
            this.pagal_Uzsakymo_IDToolStripButton.Text = "pagal_Uzsakymo_ID";
            this.pagal_Uzsakymo_IDToolStripButton.Click += new System.EventHandler(this.pagal_Uzsakymo_IDToolStripButton_Click);
            // 
            // pagal_Vartotojo_IDToolStrip
            // 
            this.pagal_Vartotojo_IDToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.pagal_Vartotojo_IDToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idToolStripLabel1,
            this.idToolStripTextBox1,
            this.pagal_Vartotojo_IDToolStripButton});
            this.pagal_Vartotojo_IDToolStrip.Location = new System.Drawing.Point(0, 0);
            this.pagal_Vartotojo_IDToolStrip.Name = "pagal_Vartotojo_IDToolStrip";
            this.pagal_Vartotojo_IDToolStrip.Size = new System.Drawing.Size(737, 27);
            this.pagal_Vartotojo_IDToolStrip.TabIndex = 3;
            this.pagal_Vartotojo_IDToolStrip.Text = "pagal_Vartotojo_IDToolStrip";
            // 
            // idToolStripLabel1
            // 
            this.idToolStripLabel1.Name = "idToolStripLabel1";
            this.idToolStripLabel1.Size = new System.Drawing.Size(25, 24);
            this.idToolStripLabel1.Text = "id:";
            // 
            // idToolStripTextBox1
            // 
            this.idToolStripTextBox1.Name = "idToolStripTextBox1";
            this.idToolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            // 
            // pagal_Vartotojo_IDToolStripButton
            // 
            this.pagal_Vartotojo_IDToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.pagal_Vartotojo_IDToolStripButton.Name = "pagal_Vartotojo_IDToolStripButton";
            this.pagal_Vartotojo_IDToolStripButton.Size = new System.Drawing.Size(140, 24);
            this.pagal_Vartotojo_IDToolStripButton.Text = "pagal_Vartotojo_ID";
            this.pagal_Vartotojo_IDToolStripButton.Click += new System.EventHandler(this.pagal_Vartotojo_IDToolStripButton_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 442);
            this.Controls.Add(this.uzsakymaiDataGridView);
            this.Controls.Add(this.pagal_Uzsakymo_IDToolStrip);
            this.Controls.Add(this.pagal_Vartotojo_IDToolStrip);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.duomenuBazeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uzsakymaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uzsakymaiDataGridView)).EndInit();
            this.pagal_Uzsakymo_IDToolStrip.ResumeLayout(false);
            this.pagal_Uzsakymo_IDToolStrip.PerformLayout();
            this.pagal_Vartotojo_IDToolStrip.ResumeLayout(false);
            this.pagal_Vartotojo_IDToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DuomenuBazeDataSet duomenuBazeDataSet;
        private System.Windows.Forms.BindingSource uzsakymaiBindingSource;
        private DuomenuBazeDataSetTableAdapters.UzsakymaiTableAdapter uzsakymaiTableAdapter;
        private DuomenuBazeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView uzsakymaiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ToolStrip pagal_Uzsakymo_IDToolStrip;
        private System.Windows.Forms.ToolStripLabel idToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox idToolStripTextBox;
        private System.Windows.Forms.ToolStripButton pagal_Uzsakymo_IDToolStripButton;
        private System.Windows.Forms.ToolStrip pagal_Vartotojo_IDToolStrip;
        private System.Windows.Forms.ToolStripLabel idToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox idToolStripTextBox1;
        private System.Windows.Forms.ToolStripButton pagal_Vartotojo_IDToolStripButton;
    }
}