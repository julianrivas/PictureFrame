
namespace Presentation.Forms
{
    partial class PreferencesForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreferencesForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TextBox_Image_PictureFolder = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CheckBox_Image_EnclosedFolders = new System.Windows.Forms.CheckBox();
            this.Button_Image_SelectFolder = new System.Windows.Forms.Button();
            this.ComboBox_Image_PictureChange = new System.Windows.Forms.ComboBox();
            this.ComboBox_Image_PictureSort = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboBox_Image_PictureRepository = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ComboBox_Frame_ResizeFrom = new System.Windows.Forms.ComboBox();
            this.ComboBox_Frame_Appereance = new System.Windows.Forms.ComboBox();
            this.TextBox_Frame_PictureSize = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.TrackBar_Window_Opacity = new System.Windows.Forms.TrackBar();
            this.label17 = new System.Windows.Forms.Label();
            this.ComboBox_Window_Level = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.CheckBox_Window_PreventDragging = new System.Windows.Forms.CheckBox();
            this.CheckBox_Window_IgnoreMouse = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_Save = new System.Windows.Forms.Button();
            this.FolderBrowserDialog_Image = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_Window_Opacity)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(427, 435);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage1.Controls.Add(this.TextBox_Image_PictureFolder);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.CheckBox_Image_EnclosedFolders);
            this.tabPage1.Controls.Add(this.Button_Image_SelectFolder);
            this.tabPage1.Controls.Add(this.ComboBox_Image_PictureChange);
            this.tabPage1.Controls.Add(this.ComboBox_Image_PictureSort);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.ComboBox_Image_PictureRepository);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(419, 407);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Image";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TextBox_Image_PictureFolder
            // 
            this.TextBox_Image_PictureFolder.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.TextBox_Image_PictureFolder.Location = new System.Drawing.Point(142, 104);
            this.TextBox_Image_PictureFolder.Name = "TextBox_Image_PictureFolder";
            this.TextBox_Image_PictureFolder.Size = new System.Drawing.Size(208, 23);
            this.TextBox_Image_PictureFolder.TabIndex = 8;
            this.TextBox_Image_PictureFolder.TextChanged += new System.EventHandler(this.TextBox_Image_PictureFolder_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(142, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(245, 60);
            this.label6.TabIndex = 11;
            this.label6.Text = "Check this box if you would like to display \r\nimages that might be enclosed in th" +
    "is folder. \r\nDepending on how deep the folders go, this \r\nmay cause excessive di" +
    "sk use.";
            // 
            // CheckBox_Image_EnclosedFolders
            // 
            this.CheckBox_Image_EnclosedFolders.AutoSize = true;
            this.CheckBox_Image_EnclosedFolders.Location = new System.Drawing.Point(142, 134);
            this.CheckBox_Image_EnclosedFolders.Name = "CheckBox_Image_EnclosedFolders";
            this.CheckBox_Image_EnclosedFolders.Size = new System.Drawing.Size(156, 19);
            this.CheckBox_Image_EnclosedFolders.TabIndex = 10;
            this.CheckBox_Image_EnclosedFolders.Text = "Look In Enclosed Folders";
            this.CheckBox_Image_EnclosedFolders.UseVisualStyleBackColor = true;
            this.CheckBox_Image_EnclosedFolders.CheckedChanged += new System.EventHandler(this.CheckBox_Image_EnclosedFolders_CheckedChanged);
            // 
            // Button_Image_SelectFolder
            // 
            this.Button_Image_SelectFolder.Location = new System.Drawing.Point(356, 104);
            this.Button_Image_SelectFolder.Name = "Button_Image_SelectFolder";
            this.Button_Image_SelectFolder.Size = new System.Drawing.Size(28, 23);
            this.Button_Image_SelectFolder.TabIndex = 9;
            this.Button_Image_SelectFolder.Text = "...";
            this.Button_Image_SelectFolder.UseVisualStyleBackColor = true;
            this.Button_Image_SelectFolder.Click += new System.EventHandler(this.Button_Image_SelectFolder_Click);
            // 
            // ComboBox_Image_PictureChange
            // 
            this.ComboBox_Image_PictureChange.FormattingEnabled = true;
            this.ComboBox_Image_PictureChange.Location = new System.Drawing.Point(142, 75);
            this.ComboBox_Image_PictureChange.Name = "ComboBox_Image_PictureChange";
            this.ComboBox_Image_PictureChange.Size = new System.Drawing.Size(182, 23);
            this.ComboBox_Image_PictureChange.TabIndex = 7;
            this.ComboBox_Image_PictureChange.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Image_PictureChange_SelectedIndexChanged);
            // 
            // ComboBox_Image_PictureSort
            // 
            this.ComboBox_Image_PictureSort.FormattingEnabled = true;
            this.ComboBox_Image_PictureSort.Location = new System.Drawing.Point(142, 46);
            this.ComboBox_Image_PictureSort.Name = "ComboBox_Image_PictureSort";
            this.ComboBox_Image_PictureSort.Size = new System.Drawing.Size(182, 23);
            this.ComboBox_Image_PictureSort.TabIndex = 6;
            this.ComboBox_Image_PictureSort.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Image_PictureSort_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Select Picture Folder...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Change Picture:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sort Pictures:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-185, -35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // ComboBox_Image_PictureRepository
            // 
            this.ComboBox_Image_PictureRepository.FormattingEnabled = true;
            this.ComboBox_Image_PictureRepository.Location = new System.Drawing.Point(142, 17);
            this.ComboBox_Image_PictureRepository.Name = "ComboBox_Image_PictureRepository";
            this.ComboBox_Image_PictureRepository.Size = new System.Drawing.Size(182, 23);
            this.ComboBox_Image_PictureRepository.TabIndex = 1;
            this.ComboBox_Image_PictureRepository.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Image_PictureRepository_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Show Pictures From:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.ComboBox_Frame_ResizeFrom);
            this.tabPage2.Controls.Add(this.ComboBox_Frame_Appereance);
            this.tabPage2.Controls.Add(this.TextBox_Frame_PictureSize);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(419, 407);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Frame";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(150, 186);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(250, 45);
            this.label12.TabIndex = 8;
            this.label12.Text = "When your pictures change size, you can set\r\nwhere the frame is anchored. It can " +
    "also figure\r\nit out automatically.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(150, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(260, 15);
            this.label11.TabIndex = 7;
            this.label11.Text = "Choose a frame style to suit your mood or taste.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(150, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(252, 45);
            this.label10.TabIndex = 6;
            this.label10.Text = "If you have pictures in your collection that are\r\nwider or taller than the above " +
    "size, they will be \r\nscaled down to this size.";
            // 
            // ComboBox_Frame_ResizeFrom
            // 
            this.ComboBox_Frame_ResizeFrom.FormattingEnabled = true;
            this.ComboBox_Frame_ResizeFrom.Location = new System.Drawing.Point(150, 160);
            this.ComboBox_Frame_ResizeFrom.Name = "ComboBox_Frame_ResizeFrom";
            this.ComboBox_Frame_ResizeFrom.Size = new System.Drawing.Size(121, 23);
            this.ComboBox_Frame_ResizeFrom.TabIndex = 5;
            this.ComboBox_Frame_ResizeFrom.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Frame_ResizeFrom_SelectedIndexChanged);
            // 
            // ComboBox_Frame_Appereance
            // 
            this.ComboBox_Frame_Appereance.FormattingEnabled = true;
            this.ComboBox_Frame_Appereance.Location = new System.Drawing.Point(150, 102);
            this.ComboBox_Frame_Appereance.Name = "ComboBox_Frame_Appereance";
            this.ComboBox_Frame_Appereance.Size = new System.Drawing.Size(173, 23);
            this.ComboBox_Frame_Appereance.TabIndex = 4;
            this.ComboBox_Frame_Appereance.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Frame_Appereance_SelectedIndexChanged);
            // 
            // TextBox_Frame_PictureSize
            // 
            this.TextBox_Frame_PictureSize.Location = new System.Drawing.Point(150, 17);
            this.TextBox_Frame_PictureSize.Name = "TextBox_Frame_PictureSize";
            this.TextBox_Frame_PictureSize.Size = new System.Drawing.Size(252, 23);
            this.TextBox_Frame_PictureSize.TabIndex = 3;
            this.TextBox_Frame_PictureSize.TextChanged += new System.EventHandler(this.TextBox_Frame_PictureSize_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Resize From:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Frame Appearance:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Maximun Picture Size:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label21);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.TrackBar_Window_Opacity);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.ComboBox_Window_Level);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.CheckBox_Window_PreventDragging);
            this.tabPage3.Controls.Add(this.CheckBox_Window_IgnoreMouse);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(419, 407);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Window";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(146, 406);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(192, 15);
            this.label21.TabIndex = 12;
            this.label21.Text = "Set the transparency of the Widget.";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(360, 380);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 15);
            this.label20.TabIndex = 11;
            this.label20.Text = "100%";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(146, 380);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 15);
            this.label18.TabIndex = 9;
            this.label18.Text = "20%";
            // 
            // TrackBar_Window_Opacity
            // 
            this.TrackBar_Window_Opacity.Location = new System.Drawing.Point(146, 331);
            this.TrackBar_Window_Opacity.Minimum = 2;
            this.TrackBar_Window_Opacity.Name = "TrackBar_Window_Opacity";
            this.TrackBar_Window_Opacity.Size = new System.Drawing.Size(249, 45);
            this.TrackBar_Window_Opacity.TabIndex = 8;
            this.TrackBar_Window_Opacity.Value = 2;
            this.TrackBar_Window_Opacity.Scroll += new System.EventHandler(this.TrackBar_Window_Opacity_Scroll);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(78, 331);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 15);
            this.label17.TabIndex = 7;
            this.label17.Text = "Opacity:";
            // 
            // ComboBox_Window_Level
            // 
            this.ComboBox_Window_Level.FormattingEnabled = true;
            this.ComboBox_Window_Level.Location = new System.Drawing.Point(146, 16);
            this.ComboBox_Window_Level.Name = "ComboBox_Window_Level";
            this.ComboBox_Window_Level.Size = new System.Drawing.Size(258, 23);
            this.ComboBox_Window_Level.TabIndex = 6;
            this.ComboBox_Window_Level.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Window_Level_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(146, 238);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(249, 75);
            this.label16.TabIndex = 5;
            this.label16.Text = "Checking this box turns off the ability to drag \r\nthe Widget with the mouse. To m" +
    "ove the \r\nWidget, you can either hold the control key \r\ndown and drag, or enter " +
    "Heads Up Display \r\nmode.";
            // 
            // CheckBox_Window_PreventDragging
            // 
            this.CheckBox_Window_PreventDragging.AutoSize = true;
            this.CheckBox_Window_PreventDragging.Location = new System.Drawing.Point(146, 216);
            this.CheckBox_Window_PreventDragging.Name = "CheckBox_Window_PreventDragging";
            this.CheckBox_Window_PreventDragging.Size = new System.Drawing.Size(118, 19);
            this.CheckBox_Window_PreventDragging.TabIndex = 4;
            this.CheckBox_Window_PreventDragging.Text = "Prevent Dragging";
            this.CheckBox_Window_PreventDragging.UseVisualStyleBackColor = true;
            this.CheckBox_Window_PreventDragging.CheckedChanged += new System.EventHandler(this.CheckBox_Window_PreventDragging_CheckedChanged);
            // 
            // CheckBox_Window_IgnoreMouse
            // 
            this.CheckBox_Window_IgnoreMouse.AutoSize = true;
            this.CheckBox_Window_IgnoreMouse.Location = new System.Drawing.Point(146, 119);
            this.CheckBox_Window_IgnoreMouse.Name = "CheckBox_Window_IgnoreMouse";
            this.CheckBox_Window_IgnoreMouse.Size = new System.Drawing.Size(99, 19);
            this.CheckBox_Window_IgnoreMouse.TabIndex = 3;
            this.CheckBox_Window_IgnoreMouse.Text = "Ignore Mouse";
            this.CheckBox_Window_IgnoreMouse.UseVisualStyleBackColor = true;
            this.CheckBox_Window_IgnoreMouse.CheckedChanged += new System.EventHandler(this.CheckBox_Window_IgnoreMouse_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(146, 141);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(255, 60);
            this.label15.TabIndex = 2;
            this.label15.Text = "Checking this box causes the Widget to ignore \r\nall mouse events. If you turn thi" +
    "s on, you can \r\nstill interact with the Widget in Heads Up \r\nmode.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(150, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(254, 60);
            this.label14.TabIndex = 1;
            this.label14.Text = "This setting controls the relative layer of \r\nwindows in this Widget. You can use" +
    " it to have \r\nyour Widget always be on top of other \r\nwindows, for example.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(45, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "Window Level:";
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Location = new System.Drawing.Point(348, 482);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Button_Cancel.TabIndex = 13;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Button_Save
            // 
            this.Button_Save.Location = new System.Drawing.Point(267, 482);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(75, 23);
            this.Button_Save.TabIndex = 12;
            this.Button_Save.Text = "Save";
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Presentation.Properties.Resources.preferences_images;
            this.panel1.Location = new System.Drawing.Point(10, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(35, 30);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(55, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(35, 30);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Location = new System.Drawing.Point(100, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(35, 30);
            this.panel3.TabIndex = 15;
            // 
            // PreferencesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 516);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_Save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PreferencesForm";
            this.Text = "Picture Frame Settings";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_Window_Opacity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboBox_Image_PictureRepository;
        private System.Windows.Forms.ComboBox ComboBox_Image_PictureChange;
        private System.Windows.Forms.ComboBox ComboBox_Image_PictureSort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox CheckBox_Image_EnclosedFolders;
        private System.Windows.Forms.Button Button_Image_SelectFolder;
        private System.Windows.Forms.TextBox TextBox_Image_PictureFolder;
        private System.Windows.Forms.ComboBox ComboBox_Frame_ResizeFrom;
        private System.Windows.Forms.ComboBox ComboBox_Frame_Appereance;
        private System.Windows.Forms.TextBox TextBox_Frame_PictureSize;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TrackBar TrackBar_Window_Opacity;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox ComboBox_Window_Level;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox CheckBox_Window_PreventDragging;
        private System.Windows.Forms.CheckBox CheckBox_Window_IgnoreMouse;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog_Image;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

