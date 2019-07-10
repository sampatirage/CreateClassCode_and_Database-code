using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WriteClassCode
{
    public partial class MainForm : Form
    {
        List<TextBox> textBoxes = new List<TextBox>();
        List<ComboBox> comboBoxVisi = new List<ComboBox>();
        List<ComboBox> comboBoxType = new List<ComboBox>();
               
        int pointX = 30;
        int pointY = 40;
        string varVisibility = "  ";  // default visibility of variables
      

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
                     
            panel1.Controls.Clear();          
           
        }

        private void btnButon1_Click(object sender, EventArgs e)
        {

            if (txbClassName.Text.Length < 1)
            {
                MessageBox.Show(" Enter class name or table name first ");
                return;                  //    ---------------------------------- return -------
            }

            // comboBox to select visibility of variable
            ComboBox c = new ComboBox();
            c.Items.AddRange(new object[] {
            "private",
            "public",
            "internal"});
            c.Location = new System.Drawing.Point(pointX, pointY);
            panel1.Controls.Add(c);
            comboBoxVisi.Add(c);

            // comboBox to select type of variable
            ComboBox t = new ComboBox();
            t.Items.AddRange(new object[] {
            "string",
            "int",
            "char",
            "float",
            "double",
            "decimal",
            "bool",
            "DateTime"});
            t.SelectedIndex = 0; 
            t.Location = new System.Drawing.Point(pointX+150, pointY);
            panel1.Controls.Add(t);
            comboBoxType.Add(t);

            // comboBox variable names

            TextBox a = new TextBox();
            a.Text = ("newVar");
            a.Location = new Point(pointX+300, pointY);
            panel1.Controls.Add(a);
            textBoxes.Add(a);


            panel1.Show();
            pointY += 20;        

        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            // generate class name and headings
            string outString = "";
            if (txbClassName.Text.Length < 1)
            {
                MessageBox.Show(" Enter class name to create");
            }
            else
            {
                string classVisibility = (cBoxClassVisibility.SelectedItem!=null)? (cBoxClassVisibility.SelectedItem.ToString()): (" ");
                    
                // string classType = ()
                
                outString = classVisibility +"  class "+ txbClassName.Text + "\r\n { \r\n ";
            }
           
            // generate variable names - properties

            TextBox[] T1 = textBoxes.ToArray();
            ComboBox[] CVisibility = comboBoxVisi.ToArray();
            ComboBox[] Ctype = comboBoxType.ToArray();

            string constructorHeader = " public " + txbClassName.Text + "( ";
            string constructorBody = "";

            for (int i = 0; i < T1.Length; i++)
            {
                // outString += varVisibility +  textBoxs[i].Text + "; ";
                if (comboBoxVisi[i].SelectedItem != null)
                {
                    outString += "\t" + comboBoxVisi[i].SelectedItem.ToString() + " "
                       + comboBoxType[i].SelectedItem.ToString() + " " + textBoxes[i].Text + " {get; set;} \r\n ";
                }
                else
                {
                    outString += ($"\t  {varVisibility}   {comboBoxType[i].SelectedItem.ToString()}  {textBoxes[i].Text} ")+ " {get; set;} \r\n ";
                }

                // if Not the first item add a preceeding comma 
                // add type of variable and the variable name - lower case
                constructorHeader += ((i==0)? " ": ",") +comboBoxType[i].SelectedItem.ToString() + " " + textBoxes[i].Text.ToLower()+ " ";

                constructorBody += ($" this.{textBoxes[i].Text} = {textBoxes[i].Text.ToLower()} ;\r\n "); 
            }

            txbShowCode.Text = outString + constructorHeader + ") \r\n { \r\n" +  constructorBody + "}\r\n }";        
            

        } // end btnWriteFile_Click

        private void btnDatabaseCode_Click(object sender, EventArgs e)
        {
            WriteInsertToDatabaseCode();

        }

        private void WriteInsertToDatabaseCode()
        {
            if (txbClassName.Text.Length < 1)
            {
                MessageBox.Show(" Enter class name or table name ");
                return;                  //    ---------------------------------- return -------
            }

            // generate variable names - properties

            TextBox[] T1 = textBoxes.ToArray();
            //  ComboBox[] CVisibility = comboBoxVisi.ToArray();
            ComboBox[] Ctype = comboBoxType.ToArray();

            string methodInitiation = "  string returnStr = \"\"; \r\n "
            + " string cmdString = \" INSERT INTO  " + txbClassName.Text.Trim() + "( ";
            string methodSignatureStart = " public static string InserInto" + txbClassName.Text.Trim() + " ( ";
            string dbCommand = " \r\n // System.Data.OleDb.OleDbCommand  "
                + "  cmd1 = new System.Data.OleDb.OleDbCommand(cmdString, conn); \r\n "
                +" SqlCommand cmd1 = new SqlCommand(cmdString, conn); \r\n ";


            string methodSignature = "";
            string insertColumnNames = "";
            string insertValueNames = "";
            string methodBodyAdd = "";
            string methodBodyValue = "";
            string methodBodyTry = " \r\n  conn.Open(); \r\n   int rowsAffected = 0; \r\n "
                + " try         // Insert data to table "
           + "\r\n { \r\n  rowsAffected = cmd1.ExecuteNonQuery(); \r\n   }\r\n"
            + " catch (Exception e) \r\n   { \r\n  returnStr = (e.Message + \" Error inserting to database : \" ); \r\n  }";

            string methodBodyEnd = " if (rowsAffected > 0) \r\n  {   returnStr= ($\" {rowsAffected} rows inserted\"); \n\r  } "
            + " \r\n  conn.Close(); \r\n    \t return returnStr;  \r\n }  ";


            for (int i = 0; i < T1.Length; i++)
            {
                string varType = "";
                // determine the type of column depening on type of variable
                switch (comboBoxType[i].SelectedItem.ToString().ToUpper())
                {
                    case "STRING":
                        varType = "Char"; // money in sql
                        break;
                    case "INT":
                        varType = "Integer";  // int in Sql server
                        break;
                    case "FLOAT":
                        varType = "Single";
                        break;
                    case "DOUBLE":
                        varType = "Double";
                        break;
                    case "DECIMAL":
                        varType = "Currency"; // money in sql
                        break;
                    case "DATETIME":
                        varType = "DatyTime"; // l
                        break;
                    default:
                        varType = "Char";
                        break;
                        /* "int",
            //  "char",             "bool", will default to VarChar
            "DateTime"})
                         */
                }

                methodSignature += ", " + comboBoxType[i].SelectedItem.ToString() + " " + textBoxes[i].Text;


                insertColumnNames += ($", {textBoxes[i].Text}");
                insertValueNames += ($", @{textBoxes[i].Text}");

                // first comma  will be removed later
                // add type of variable and the variable name - lower case

                //   cmd1.Parameters.AddWithValue("@Name", Name);

                methodBodyAdd += ($"cmd1.Parameters.AddWithValue(\"@{ textBoxes[i].Text}\", {textBoxes[i].Text});\r\n  ");
               // methodBodyValue += ($"cmd1.Parameters[\"@{ textBoxes[i].Text}\"].Value = {textBoxes[i].Text};\r\n ");


            }

            // remove the ',' at the start from column name, variable name strings
            methodSignature = methodSignatureStart + methodSignature.Substring(1);
            insertColumnNames = insertColumnNames.Substring(1);
            insertValueNames = insertValueNames.Substring(1);
            // methodSignature = methodSignature.Replace()


            // final string 
            txbShowCode.Text = methodSignature + " ) \r\n { \r\n "
                + methodInitiation
                + insertColumnNames + " ) VALUES ("
                + insertValueNames + ");\";\r\n "
                + dbCommand + "\r\n"
                + methodBodyAdd + "\r\n "  // example cmd1.Parameters.Add("@itemName", OleDbType.VarChar);
                + methodBodyValue + "\r\n \r\n"   // example  cmd1.Parameters["@itemName"].Value = itemName;
                + methodBodyTry   // execute insert command in try catch 
                + methodBodyEnd
                + " ";
        }
        // end WriteInsertToDatabaseCode


        private void WriteEditToDatabaseCode()
        {
            if (txbClassName.Text.Length < 1)
            {
                MessageBox.Show(" Enter class name or table name ");
                return;                  //    ---------------------------------- return -------
            }

            // generate variable names - properties

            TextBox[] T1 = textBoxes.ToArray();
            //  ComboBox[] CVisibility = comboBoxVisi.ToArray();
            ComboBox[] Ctype = comboBoxType.ToArray();

            string methodInitiation = "  string returnStr = \"\"; \r\n "
            + " string cmdString = \" UPDATE " + txbClassName.Text.Trim() + " SET  ";
            string methodSignatureStart = " public static string EditRecord" + txbClassName.Text.Trim() + " ( ";
            string dbCommand = " \r\n // System.Data.OleDb.OleDbCommand  "
                + "  cmd1 = new System.Data.OleDb.OleDbCommand(cmdString, conn); \r\n "
                +" SqlCommand cmd1 = new SqlCommand(cmdString, conn); \r\n ";


            string methodSignature = "";          
            string insertColumnValuePairs = "";
            string methodBodyAdd = "";
            string methodBodyValue = "";
            string methodBodyTry = " \r\n  conn.Open(); \r\n   int rowsAffected = 0; \r\n "
                + " try         // Edit data in table "
           + "\r\n { \r\n  rowsAffected = cmd1.ExecuteNonQuery(); \r\n   }\r\n"
            + " catch (Exception e) \r\n   { \r\n  returnStr = (e.Message + \" Error inserting to database : \" ); \r\n  }";

            string methodBodyEnd = " if (rowsAffected > 0) \r\n  {   returnStr= ($\" {rowsAffected} rows edited\"); \n\r  } "
            + " \r\n  conn.Close(); \r\n    \t return returnStr;  \r\n }  ";

            string whereClause = ($" WHERE {textBoxes[0].Text} =@{textBoxes[0].Text} ");

            int i = 0;
            for ( ; i < T1.Length; i++)
            {
                string varType = "";
                // determine the type of column depening on type of variable
                switch (comboBoxType[i].SelectedItem.ToString().ToUpper())
                {
                    case "STRING":
                        varType = "VarChar"; // 
                        break;
                    case "INT":
                        varType = "Integer";  // int in Sql server
                        break;
                    case "FLOAT":
                        varType = "Single";
                        break;
                    case "DOUBLE":
                        varType = "Double";
                        break;
                    case "DECIMAL":
                        varType = "Currency"; // money in sql
                        break;
                    case "DATETIME":
                        varType = "DatyTime"; // l
                        break;
                    case "BOOL":
                        varType = "Boolean"; // l
                        break;
                    default:
                        varType = "Char";
                        break;                    
                }  // end switch 

                methodSignature += ", " + comboBoxType[i].SelectedItem.ToString() + " " + textBoxes[i].Text;
                if (i > 0)   
                {                   // Update SQL command, Add and Value methods skip first column -primary key 
                    insertColumnValuePairs += ($", {textBoxes[i].Text} = @{textBoxes[i].Text}");
                   // methodBodyAdd += ($"cmd1.Parameters.Add(\"@{ textBoxes[i].Text}\", System.Data.OleDb.OleDbType.{varType});\r\n ");
                    methodBodyAdd += ($"cmd1.Parameters.AddWithValue(\"@{ textBoxes[i].Text}\", {textBoxes[i].Text});\r\n  ");

                   // methodBodyValue += ($"cmd1.Parameters[\"@{ textBoxes[i].Text}\"].Value = {textBoxes[i].Text};\r\n ");
                }
            }  //end for (i)

            // first comma  will be removed later
            // add the last where clause Add and value methods 

           // methodBodyAdd += ($"cmd1.Parameters.Add(\"@{ textBoxes[0].Text}\", " +
            //      $"System.Data.OleDb.OleDbType.{comboBoxType[0].SelectedItem.ToString()});\r\n ");

           // methodBodyValue += ($"cmd1.Parameters[\"@{ textBoxes[0].Text}\"].Value = {textBoxes[0].Text};\r\n ");         

            // remove the ',' at the start from column name, variable name strings
            methodSignature = methodSignatureStart + methodSignature.Substring(1);
            insertColumnValuePairs = insertColumnValuePairs.Substring(1);

            // final string 
            txbShowCode.Text = methodSignature + " ) \r\n { \r\n "
                + methodInitiation
                + insertColumnValuePairs + whereClause +" \" ;\r\n "
                + dbCommand + "\r\n"
                + methodBodyAdd + "\r\n "  // example cmd1.Parameters.Add("@itemName", OleDbType.VarChar);
                + methodBodyValue + "\r\n \r\n"   // example  cmd1.Parameters["@itemName"].Value = itemName;
                + methodBodyTry   // execute insert command in try catch 
                + methodBodyEnd
                + " ";
        } // end WriteEditToDatabaseCode


        private void btnEditTableItem_Click(object sender, EventArgs e)
        {
            WriteEditToDatabaseCode();
        }

    }
}
