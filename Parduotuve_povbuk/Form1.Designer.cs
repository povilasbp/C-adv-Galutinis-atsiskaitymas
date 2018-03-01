namespace Parduotuve_povbuk
{
    partial class Form1
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
            System.Windows.Forms.Label vartotojo_IDLabel;
            System.Windows.Forms.Label vardasLabel;
            System.Windows.Forms.Label pavardeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.vartotojaiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.vartotojaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.duomenuBazeDataSet = new Parduotuve_povbuk.DuomenuBazeDataSet();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.vartotojaiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.vartotojaiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vartotojo_IDTextBox = new System.Windows.Forms.TextBox();
            this.vardasTextBox = new System.Windows.Forms.TextBox();
            this.pavardeTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonIrasas = new System.Windows.Forms.Button();
            this.buttonNaujasUzsakymas = new System.Windows.Forms.Button();
            this.vartotojaiTableAdapter = new Parduotuve_povbuk.DuomenuBazeDataSetTableAdapters.VartotojaiTableAdapter();
            this.tableAdapterManager = new Parduotuve_povbuk.DuomenuBazeDataSetTableAdapters.TableAdapterManager();
            this.buttonUzsakymai = new System.Windows.Forms.Button();
            vartotojo_IDLabel = new System.Windows.Forms.Label();
            vardasLabel = new System.Windows.Forms.Label();
            pavardeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vartotojaiBindingNavigator)).BeginInit();
            this.vartotojaiBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vartotojaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duomenuBazeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vartotojaiDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // vartotojo_IDLabel
            // 
            vartotojo_IDLabel.AutoSize = true;
            vartotojo_IDLabel.Location = new System.Drawing.Point(15, 44);
            vartotojo_IDLabel.Name = "vartotojo_IDLabel";
            vartotojo_IDLabel.Size = new System.Drawing.Size(86, 17);
            vartotojo_IDLabel.TabIndex = 0;
            vartotojo_IDLabel.Text = "Vartotojo ID:";
            // 
            // vardasLabel
            // 
            vardasLabel.AutoSize = true;
            vardasLabel.Location = new System.Drawing.Point(15, 72);
            vardasLabel.Name = "vardasLabel";
            vardasLabel.Size = new System.Drawing.Size(57, 17);
            vardasLabel.TabIndex = 2;
            vardasLabel.Text = "Vardas:";
            // 
            // pavardeLabel
            // 
            pavardeLabel.AutoSize = true;
            pavardeLabel.Location = new System.Drawing.Point(15, 100);
            pavardeLabel.Name = "pavardeLabel";
            pavardeLabel.Size = new System.Drawing.Size(65, 17);
            pavardeLabel.TabIndex = 4;
            pavardeLabel.Text = "Pavarde:";
            // 
            // vartotojaiBindingNavigator
            // 
            this.vartotojaiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vartotojaiBindingNavigator.BindingSource = this.vartotojaiBindingSource;
            this.vartotojaiBindingNavigator.CountItem = null;
            this.vartotojaiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vartotojaiBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.vartotojaiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorSeparator2,
            this.vartotojaiBindingNavigatorSaveItem,
            this.bindingNavigatorSeparator});
            this.vartotojaiBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vartotojaiBindingNavigator.MoveFirstItem = null;
            this.vartotojaiBindingNavigator.MoveLastItem = null;
            this.vartotojaiBindingNavigator.MoveNextItem = null;
            this.vartotojaiBindingNavigator.MovePreviousItem = null;
            this.vartotojaiBindingNavigator.Name = "vartotojaiBindingNavigator";
            this.vartotojaiBindingNavigator.PositionItem = null;
            this.vartotojaiBindingNavigator.Size = new System.Drawing.Size(726, 27);
            this.vartotojaiBindingNavigator.TabIndex = 0;
            this.vartotojaiBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(140, 24);
            this.bindingNavigatorAddNewItem.Text = "Prideti vartotoja";
            // 
            // vartotojaiBindingSource
            // 
            this.vartotojaiBindingSource.DataMember = "Vartotojai";
            this.vartotojaiBindingSource.DataSource = this.duomenuBazeDataSet;
            // 
            // duomenuBazeDataSet
            // 
            this.duomenuBazeDataSet.DataSetName = "DuomenuBazeDataSet";
            this.duomenuBazeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(155, 24);
            this.bindingNavigatorDeleteItem.Text = "Pasalinti pasirinkta";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // vartotojaiBindingNavigatorSaveItem
            // 
            this.vartotojaiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vartotojaiBindingNavigatorSaveItem.Image")));
            this.vartotojaiBindingNavigatorSaveItem.Name = "vartotojaiBindingNavigatorSaveItem";
            this.vartotojaiBindingNavigatorSaveItem.Size = new System.Drawing.Size(168, 24);
            this.vartotojaiBindingNavigatorSaveItem.Text = "Issaugoti pakeitimus";
            this.vartotojaiBindingNavigatorSaveItem.Click += new System.EventHandler(this.vartotojaiBindingNavigatorSaveItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // vartotojaiDataGridView
            // 
            this.vartotojaiDataGridView.AutoGenerateColumns = false;
            this.vartotojaiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vartotojaiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.vartotojaiDataGridView.DataSource = this.vartotojaiBindingSource;
            this.vartotojaiDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.vartotojaiDataGridView.Location = new System.Drawing.Point(0, 27);
            this.vartotojaiDataGridView.Name = "vartotojaiDataGridView";
            this.vartotojaiDataGridView.RowTemplate.Height = 24;
            this.vartotojaiDataGridView.Size = new System.Drawing.Size(726, 173);
            this.vartotojaiDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Vartotojo ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Vartotojo ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Vardas";
            this.dataGridViewTextBoxColumn2.HeaderText = "Vardas";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Pavarde";
            this.dataGridViewTextBoxColumn3.HeaderText = "Pavarde";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Gimimo data";
            this.dataGridViewTextBoxColumn4.HeaderText = "Gimimo data";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Adresas";
            this.dataGridViewTextBoxColumn5.HeaderText = "Adresas";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(vartotojo_IDLabel);
            this.groupBox1.Controls.Add(this.vartotojo_IDTextBox);
            this.groupBox1.Controls.Add(vardasLabel);
            this.groupBox1.Controls.Add(this.vardasTextBox);
            this.groupBox1.Controls.Add(pavardeLabel);
            this.groupBox1.Controls.Add(this.pavardeTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 140);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pasirinktas vartotojas:";
            // 
            // vartotojo_IDTextBox
            // 
            this.vartotojo_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vartotojaiBindingSource, "Vartotojo ID", true));
            this.vartotojo_IDTextBox.Enabled = false;
            this.vartotojo_IDTextBox.Location = new System.Drawing.Point(112, 41);
            this.vartotojo_IDTextBox.Name = "vartotojo_IDTextBox";
            this.vartotojo_IDTextBox.Size = new System.Drawing.Size(200, 22);
            this.vartotojo_IDTextBox.TabIndex = 1;
            // 
            // vardasTextBox
            // 
            this.vardasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vartotojaiBindingSource, "Vardas", true));
            this.vardasTextBox.Enabled = false;
            this.vardasTextBox.Location = new System.Drawing.Point(112, 69);
            this.vardasTextBox.Name = "vardasTextBox";
            this.vardasTextBox.Size = new System.Drawing.Size(200, 22);
            this.vardasTextBox.TabIndex = 3;
            // 
            // pavardeTextBox
            // 
            this.pavardeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vartotojaiBindingSource, "Pavarde", true));
            this.pavardeTextBox.Enabled = false;
            this.pavardeTextBox.Location = new System.Drawing.Point(112, 97);
            this.pavardeTextBox.Name = "pavardeTextBox";
            this.pavardeTextBox.Size = new System.Drawing.Size(200, 22);
            this.pavardeTextBox.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonIrasas);
            this.groupBox2.Controls.Add(this.buttonNaujasUzsakymas);
            this.groupBox2.Location = new System.Drawing.Point(354, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 140);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Veiksmai:";
            // 
            // buttonIrasas
            // 
            this.buttonIrasas.Location = new System.Drawing.Point(124, 41);
            this.buttonIrasas.Name = "buttonIrasas";
            this.buttonIrasas.Size = new System.Drawing.Size(102, 79);
            this.buttonIrasas.TabIndex = 1;
            this.buttonIrasas.Text = "Sukurti irasa i uzsakyma";
            this.buttonIrasas.UseVisualStyleBackColor = true;
            this.buttonIrasas.Click += new System.EventHandler(this.buttonIrasas_Click);
            // 
            // buttonNaujasUzsakymas
            // 
            this.buttonNaujasUzsakymas.Location = new System.Drawing.Point(16, 41);
            this.buttonNaujasUzsakymas.Name = "buttonNaujasUzsakymas";
            this.buttonNaujasUzsakymas.Size = new System.Drawing.Size(102, 79);
            this.buttonNaujasUzsakymas.TabIndex = 0;
            this.buttonNaujasUzsakymas.Text = "Sukurti nauja uzsakyma";
            this.buttonNaujasUzsakymas.UseVisualStyleBackColor = true;
            this.buttonNaujasUzsakymas.Click += new System.EventHandler(this.buttonNaujasUzsakymas_Click);
            // 
            // vartotojaiTableAdapter
            // 
            this.vartotojaiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.IrasaiTableAdapter = null;
            this.tableAdapterManager.PrekesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Parduotuve_povbuk.DuomenuBazeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UzsakymaiTableAdapter = null;
            this.tableAdapterManager.VartotojaiTableAdapter = this.vartotojaiTableAdapter;
            // 
            // buttonUzsakymai
            // 
            this.buttonUzsakymai.Location = new System.Drawing.Point(612, 221);
            this.buttonUzsakymai.Name = "buttonUzsakymai";
            this.buttonUzsakymai.Size = new System.Drawing.Size(102, 126);
            this.buttonUzsakymai.TabIndex = 2;
            this.buttonUzsakymai.Text = "Rodyti visus uzsakymus";
            this.buttonUzsakymai.UseVisualStyleBackColor = true;
            this.buttonUzsakymai.Click += new System.EventHandler(this.buttonUzsakymai_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 364);
            this.Controls.Add(this.buttonUzsakymai);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.vartotojaiDataGridView);
            this.Controls.Add(this.vartotojaiBindingNavigator);
            this.Name = "Form1";
            this.Text = "Pagrindinis";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vartotojaiBindingNavigator)).EndInit();
            this.vartotojaiBindingNavigator.ResumeLayout(false);
            this.vartotojaiBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vartotojaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duomenuBazeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vartotojaiDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DuomenuBazeDataSet duomenuBazeDataSet;
        private System.Windows.Forms.BindingSource vartotojaiBindingSource;
        private DuomenuBazeDataSetTableAdapters.VartotojaiTableAdapter vartotojaiTableAdapter;
        private DuomenuBazeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vartotojaiBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton vartotojaiBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView vartotojaiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox vartotojo_IDTextBox;
        private System.Windows.Forms.TextBox vardasTextBox;
        private System.Windows.Forms.TextBox pavardeTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonNaujasUzsakymas;
        private System.Windows.Forms.Button buttonIrasas;
        private System.Windows.Forms.Button buttonUzsakymai;
    }
}

