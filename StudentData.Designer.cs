namespace EhlertProgram12
{
    partial class frmStudentData
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
            System.Windows.Forms.Label student_IDLabel;
            System.Windows.Forms.Label student_FirstNameLabel;
            System.Windows.Forms.Label student_LastNameLabel;
            System.Windows.Forms.Label major_IDLabel;
            System.Windows.Forms.Label major_NameLabel;
            System.Windows.Forms.Label major_ChairLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentData));
            this.studentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataBaseDataSet = new EhlertProgram12.StudentDataBaseDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.studentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.studentDataGridView = new System.Windows.Forms.DataGridView();
            this.studentTableAdapter = new EhlertProgram12.StudentDataBaseDataSetTableAdapters.StudentTableAdapter();
            this.tableAdapterManager = new EhlertProgram12.StudentDataBaseDataSetTableAdapters.TableAdapterManager();
            this.student_IDTextBox = new System.Windows.Forms.TextBox();
            this.student_FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.student_LastNameTextBox = new System.Windows.Forms.TextBox();
            this.major_IDTextBox = new System.Windows.Forms.TextBox();
            this.major_NameTextBox = new System.Windows.Forms.TextBox();
            this.major_ChairTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.major_Chair = new System.Windows.Forms.DataGridViewTextBoxColumn();
            student_IDLabel = new System.Windows.Forms.Label();
            student_FirstNameLabel = new System.Windows.Forms.Label();
            student_LastNameLabel = new System.Windows.Forms.Label();
            major_IDLabel = new System.Windows.Forms.Label();
            major_NameLabel = new System.Windows.Forms.Label();
            major_ChairLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingNavigator)).BeginInit();
            this.studentBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // student_IDLabel
            // 
            student_IDLabel.AutoSize = true;
            student_IDLabel.Location = new System.Drawing.Point(12, 322);
            student_IDLabel.Name = "student_IDLabel";
            student_IDLabel.Size = new System.Drawing.Size(59, 13);
            student_IDLabel.TabIndex = 2;
            student_IDLabel.Text = "student ID:";
            // 
            // student_FirstNameLabel
            // 
            student_FirstNameLabel.AutoSize = true;
            student_FirstNameLabel.Location = new System.Drawing.Point(12, 348);
            student_FirstNameLabel.Name = "student_FirstNameLabel";
            student_FirstNameLabel.Size = new System.Drawing.Size(98, 13);
            student_FirstNameLabel.TabIndex = 4;
            student_FirstNameLabel.Text = "student First Name:";
            // 
            // student_LastNameLabel
            // 
            student_LastNameLabel.AutoSize = true;
            student_LastNameLabel.Location = new System.Drawing.Point(12, 374);
            student_LastNameLabel.Name = "student_LastNameLabel";
            student_LastNameLabel.Size = new System.Drawing.Size(99, 13);
            student_LastNameLabel.TabIndex = 6;
            student_LastNameLabel.Text = "student Last Name:";
            // 
            // major_IDLabel
            // 
            major_IDLabel.AutoSize = true;
            major_IDLabel.Location = new System.Drawing.Point(12, 400);
            major_IDLabel.Name = "major_IDLabel";
            major_IDLabel.Size = new System.Drawing.Size(49, 13);
            major_IDLabel.TabIndex = 8;
            major_IDLabel.Text = "major ID:";
            // 
            // major_NameLabel
            // 
            major_NameLabel.AutoSize = true;
            major_NameLabel.Location = new System.Drawing.Point(12, 426);
            major_NameLabel.Name = "major_NameLabel";
            major_NameLabel.Size = new System.Drawing.Size(66, 13);
            major_NameLabel.TabIndex = 10;
            major_NameLabel.Text = "major Name:";
            // 
            // major_ChairLabel
            // 
            major_ChairLabel.AutoSize = true;
            major_ChairLabel.Location = new System.Drawing.Point(12, 452);
            major_ChairLabel.Name = "major_ChairLabel";
            major_ChairLabel.Size = new System.Drawing.Size(62, 13);
            major_ChairLabel.TabIndex = 12;
            major_ChairLabel.Text = "major Chair:";
            // 
            // studentBindingNavigator
            // 
            this.studentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.studentBindingNavigator.BindingSource = this.studentBindingSource;
            this.studentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.studentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.studentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.studentBindingNavigatorSaveItem});
            this.studentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.studentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.studentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.studentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.studentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.studentBindingNavigator.Name = "studentBindingNavigator";
            this.studentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.studentBindingNavigator.Size = new System.Drawing.Size(642, 25);
            this.studentBindingNavigator.TabIndex = 0;
            this.studentBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.studentDataBaseDataSet;
            // 
            // studentDataBaseDataSet
            // 
            this.studentDataBaseDataSet.DataSetName = "StudentDataBaseDataSet";
            this.studentDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // studentBindingNavigatorSaveItem
            // 
            this.studentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.studentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("studentBindingNavigatorSaveItem.Image")));
            this.studentBindingNavigatorSaveItem.Name = "studentBindingNavigatorSaveItem";
            this.studentBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.studentBindingNavigatorSaveItem.Text = "Save Data";
            this.studentBindingNavigatorSaveItem.Click += new System.EventHandler(this.studentBindingNavigatorSaveItem_Click);
            // 
            // studentDataGridView
            // 
            this.studentDataGridView.AutoGenerateColumns = false;
            this.studentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.major_Chair});
            this.studentDataGridView.DataSource = this.studentBindingSource;
            this.studentDataGridView.Location = new System.Drawing.Point(12, 28);
            this.studentDataGridView.Name = "studentDataGridView";
            this.studentDataGridView.Size = new System.Drawing.Size(610, 285);
            this.studentDataGridView.TabIndex = 1;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DepartmentTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = this.studentTableAdapter;
            this.tableAdapterManager.UpdateOrder = EhlertProgram12.StudentDataBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // student_IDTextBox
            // 
            this.student_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "student_ID", true));
            this.student_IDTextBox.Location = new System.Drawing.Point(117, 319);
            this.student_IDTextBox.Name = "student_IDTextBox";
            this.student_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.student_IDTextBox.TabIndex = 3;
            // 
            // student_FirstNameTextBox
            // 
            this.student_FirstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "student_FirstName", true));
            this.student_FirstNameTextBox.Location = new System.Drawing.Point(117, 345);
            this.student_FirstNameTextBox.Name = "student_FirstNameTextBox";
            this.student_FirstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.student_FirstNameTextBox.TabIndex = 5;
            // 
            // student_LastNameTextBox
            // 
            this.student_LastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "student_LastName", true));
            this.student_LastNameTextBox.Location = new System.Drawing.Point(117, 371);
            this.student_LastNameTextBox.Name = "student_LastNameTextBox";
            this.student_LastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.student_LastNameTextBox.TabIndex = 7;
            // 
            // major_IDTextBox
            // 
            this.major_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "major_ID", true));
            this.major_IDTextBox.Location = new System.Drawing.Point(117, 397);
            this.major_IDTextBox.Name = "major_IDTextBox";
            this.major_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.major_IDTextBox.TabIndex = 9;
            // 
            // major_NameTextBox
            // 
            this.major_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "major_Name", true));
            this.major_NameTextBox.Location = new System.Drawing.Point(117, 423);
            this.major_NameTextBox.Name = "major_NameTextBox";
            this.major_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.major_NameTextBox.TabIndex = 11;
            // 
            // major_ChairTextBox
            // 
            this.major_ChairTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "major_Chair", true));
            this.major_ChairTextBox.Location = new System.Drawing.Point(117, 449);
            this.major_ChairTextBox.Name = "major_ChairTextBox";
            this.major_ChairTextBox.Size = new System.Drawing.Size(100, 20);
            this.major_ChairTextBox.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "student_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "student_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "student_LastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "student_LastName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "student_FirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "student_FirstName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "major_ID";
            this.dataGridViewTextBoxColumn4.HeaderText = "major_ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "major_Name";
            this.dataGridViewTextBoxColumn5.HeaderText = "major_Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // major_Chair
            // 
            this.major_Chair.DataPropertyName = "major_Chair";
            this.major_Chair.HeaderText = "major_Chair";
            this.major_Chair.Name = "major_Chair";
            // 
            // frmStudentData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 508);
            this.Controls.Add(student_IDLabel);
            this.Controls.Add(this.student_IDTextBox);
            this.Controls.Add(student_FirstNameLabel);
            this.Controls.Add(this.student_FirstNameTextBox);
            this.Controls.Add(student_LastNameLabel);
            this.Controls.Add(this.student_LastNameTextBox);
            this.Controls.Add(major_IDLabel);
            this.Controls.Add(this.major_IDTextBox);
            this.Controls.Add(major_NameLabel);
            this.Controls.Add(this.major_NameTextBox);
            this.Controls.Add(major_ChairLabel);
            this.Controls.Add(this.major_ChairTextBox);
            this.Controls.Add(this.studentDataGridView);
            this.Controls.Add(this.studentBindingNavigator);
            this.Name = "frmStudentData";
            this.Text = "Student Data App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingNavigator)).EndInit();
            this.studentBindingNavigator.ResumeLayout(false);
            this.studentBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StudentDataBaseDataSet studentDataBaseDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private StudentDataBaseDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private StudentDataBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator studentBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton studentBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView studentDataGridView;
        private System.Windows.Forms.TextBox student_IDTextBox;
        private System.Windows.Forms.TextBox student_FirstNameTextBox;
        private System.Windows.Forms.TextBox student_LastNameTextBox;
        private System.Windows.Forms.TextBox major_IDTextBox;
        private System.Windows.Forms.TextBox major_NameTextBox;
        private System.Windows.Forms.TextBox major_ChairTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn major_Chair;
    }
}

