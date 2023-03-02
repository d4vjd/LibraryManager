namespace LibraryManager
{
    partial class MainForm
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

        private System.Windows.Forms.ListBox BookList;
        private System.Windows.Forms.ListBox ClientList;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.Button deleteBookButton;
        private System.Windows.Forms.Button addClientButton;
        private System.Windows.Forms.Button deleteClientButton;
        private System.Windows.Forms.Button borrowBookButton;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}