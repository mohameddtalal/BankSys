namespace banksys
{
    partial class Form2
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
            this.cUSTOMERTableAdapter = new banksys.DataSet1TableAdapters.CUSTOMERTableAdapter();
            this.tableAdapterManager = new banksys.DataSet1TableAdapters.TableAdapterManager();
            this.back = new System.Windows.Forms.Button();
            this.dataSet1 = new banksys.DataSet1();
            this.bRANCHNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bANKCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bCITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bSTATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bSTREETDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSet2 = new banksys.DataSet2();
            this.cUSTOMERBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cUSTOMERTableAdapter1 = new banksys.DataSet2TableAdapters.CUSTOMERTableAdapter();
            this.tableAdapterManager1 = new banksys.DataSet2TableAdapters.TableAdapterManager();
            this.cUSTOMERDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ACCOUNTTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANKTableAdapter = null;
            this.tableAdapterManager.BRANCHTableAdapter = null;
            this.tableAdapterManager.CUSTOMER_PHONETableAdapter = null;
            this.tableAdapterManager.CUSTOMERTableAdapter = this.cUSTOMERTableAdapter;
            this.tableAdapterManager.EMPLOYEETableAdapter = null;
            this.tableAdapterManager.HAS2TableAdapter = null;
            this.tableAdapterManager.LOANTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = banksys.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(638, 350);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(150, 30);
            this.back.TabIndex = 2;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bRANCHNODataGridViewTextBoxColumn
            // 
            this.bRANCHNODataGridViewTextBoxColumn.DataPropertyName = "BRANCHNO";
            this.bRANCHNODataGridViewTextBoxColumn.HeaderText = "BRANCHNO";
            this.bRANCHNODataGridViewTextBoxColumn.Name = "bRANCHNODataGridViewTextBoxColumn";
            // 
            // bANKCODEDataGridViewTextBoxColumn
            // 
            this.bANKCODEDataGridViewTextBoxColumn.DataPropertyName = "BANKCODE";
            this.bANKCODEDataGridViewTextBoxColumn.HeaderText = "BANKCODE";
            this.bANKCODEDataGridViewTextBoxColumn.Name = "bANKCODEDataGridViewTextBoxColumn";
            // 
            // bCITYDataGridViewTextBoxColumn
            // 
            this.bCITYDataGridViewTextBoxColumn.DataPropertyName = "B_CITY";
            this.bCITYDataGridViewTextBoxColumn.HeaderText = "B_CITY";
            this.bCITYDataGridViewTextBoxColumn.Name = "bCITYDataGridViewTextBoxColumn";
            // 
            // bSTATEDataGridViewTextBoxColumn
            // 
            this.bSTATEDataGridViewTextBoxColumn.DataPropertyName = "B_STATE";
            this.bSTATEDataGridViewTextBoxColumn.HeaderText = "B_STATE";
            this.bSTATEDataGridViewTextBoxColumn.Name = "bSTATEDataGridViewTextBoxColumn";
            // 
            // bSTREETDataGridViewTextBoxColumn
            // 
            this.bSTREETDataGridViewTextBoxColumn.DataPropertyName = "B_STREET";
            this.bSTREETDataGridViewTextBoxColumn.HeaderText = "B_STREET";
            this.bSTREETDataGridViewTextBoxColumn.Name = "bSTREETDataGridViewTextBoxColumn";
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cUSTOMERBindingSource1
            // 
            this.cUSTOMERBindingSource1.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource1.DataSource = this.dataSet2;
            // 
            // cUSTOMERTableAdapter1
            // 
            this.cUSTOMERTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.ACCOUNTTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BANKTableAdapter = null;
            this.tableAdapterManager1.BRANCHTableAdapter = null;
            this.tableAdapterManager1.CUSTOMER_PHONETableAdapter = null;
            this.tableAdapterManager1.CUSTOMERTableAdapter = this.cUSTOMERTableAdapter1;
            this.tableAdapterManager1.EMPLOYEETableAdapter = null;
            this.tableAdapterManager1.HAS2TableAdapter = null;
            this.tableAdapterManager1.LOANTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = banksys.DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cUSTOMERDataGridView
            // 
            this.cUSTOMERDataGridView.AutoGenerateColumns = false;
            this.cUSTOMERDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cUSTOMERDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.cUSTOMERDataGridView.DataSource = this.cUSTOMERBindingSource1;
            this.cUSTOMERDataGridView.Location = new System.Drawing.Point(12, 46);
            this.cUSTOMERDataGridView.Name = "cUSTOMERDataGridView";
            this.cUSTOMERDataGridView.Size = new System.Drawing.Size(659, 244);
            this.cUSTOMERDataGridView.TabIndex = 2;
            this.cUSTOMERDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cUSTOMERDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SSN";
            this.dataGridViewTextBoxColumn1.HeaderText = "SSN";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FNAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "FNAME";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LNAME";
            this.dataGridViewTextBoxColumn3.HeaderText = "LNAME";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CITY";
            this.dataGridViewTextBoxColumn4.HeaderText = "CITY";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "STATE";
            this.dataGridViewTextBoxColumn5.HeaderText = "STATE";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "STREET";
            this.dataGridViewTextBoxColumn6.HeaderText = "STREET";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // cUSTOMERBindingSource
            // 
            this.cUSTOMERBindingSource.DataMember = "CUSTOMER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "customers";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::banksys.Properties.Resources.download;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cUSTOMERDataGridView);
            this.Controls.Add(this.back);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
        private DataSet1TableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button back;
        private DataSet1 dataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bRANCHNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bANKCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bCITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bSTATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bSTREETDataGridViewTextBoxColumn;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource1;
        private DataSet2TableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter1;
        private DataSet2TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView cUSTOMERDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label1;
    }
}