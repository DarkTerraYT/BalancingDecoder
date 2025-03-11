namespace BalancingDecoderFrom
{
    partial class DecoderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DecoderForm));
            classes2 = new Button();
            events1 = new Button();
            classes1 = new Button();
            classes3 = new Button();
            customClass = new Button();
            pickBalancing = new OpenFileDialog();
            pickClassNames = new OpenFileDialog();
            classInput = new TextBox();
            classNamesList = new CheckedListBox();
            label1 = new Label();
            checkAll = new Button();
            selectBalancingData = new Button();
            balancingDataPath = new Label();
            decode = new Button();
            encodeClassList = new CheckedListBox();
            encode = new Button();
            textBox1 = new TextBox();
            addEncode = new Button();
            outputBalancingPath = new Label();
            selectOutputBalancing = new Button();
            checkAll2 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            class6 = new Button();
            classes4 = new Button();
            classes5 = new Button();
            folder = new Label();
            selectOutput = new Button();
            outputPath = new Label();
            inputPath = new Label();
            selectInput = new Button();
            input = new Label();
            selectOutputFolder = new FolderBrowserDialog();
            folderBrowserDialog1 = new FolderBrowserDialog();
            selectInputFolder = new FolderBrowserDialog();
            events3 = new Button();
            balancingNames = new Button();
            button1 = new Button();
            button2 = new Button();
            import1 = new Button();
            import2 = new Button();
            SuspendLayout();
            // 
            // classes2
            // 
            classes2.Font = new Font("Angry Birds Movie", 8.25F);
            classes2.Location = new Point(224, 100);
            classes2.Name = "classes2";
            classes2.Size = new Size(86, 21);
            classes2.TabIndex = 1;
            classes2.Text = "2.0.0 Classes";
            classes2.UseVisualStyleBackColor = true;
            classes2.Click += classes2_Click;
            // 
            // events1
            // 
            events1.Font = new Font("Angry Birds Movie", 8.25F);
            events1.Location = new Point(224, 154);
            events1.Name = "events1";
            events1.Size = new Size(86, 21);
            events1.TabIndex = 4;
            events1.Text = "Events";
            events1.UseVisualStyleBackColor = true;
            events1.Click += events1_Click;
            // 
            // classes1
            // 
            classes1.Font = new Font("Angry Birds Movie", 8.25F);
            classes1.Location = new Point(224, 73);
            classes1.Name = "classes1";
            classes1.Size = new Size(86, 21);
            classes1.TabIndex = 3;
            classes1.Text = "3.0.1 Classes";
            classes1.UseVisualStyleBackColor = true;
            classes1.Click += classes1_Click;
            // 
            // classes3
            // 
            classes3.Font = new Font("Angry Birds Movie", 8.25F);
            classes3.Location = new Point(224, 127);
            classes3.Name = "classes3";
            classes3.Size = new Size(86, 21);
            classes3.TabIndex = 5;
            classes3.Text = "1.0.14 Classes";
            classes3.UseVisualStyleBackColor = true;
            classes3.Click += classes3_Click;
            // 
            // customClass
            // 
            customClass.Location = new Point(378, 274);
            customClass.Name = "customClass";
            customClass.Size = new Size(36, 21);
            customClass.TabIndex = 7;
            customClass.Text = "Add";
            customClass.UseVisualStyleBackColor = true;
            customClass.Click += customClass_Click;
            // 
            // pickBalancing
            // 
            pickBalancing.DefaultExt = "bytes";
            pickBalancing.Filter = "Balancing files|*.bytes|All files|*";
            pickBalancing.Title = "Pick a Balancing Data File";
            // 
            // pickClassNames
            // 
            pickClassNames.Filter = "JSON string array|*.json|Name List|*.txt";
            // 
            // classInput
            // 
            classInput.Location = new Point(228, 274);
            classInput.Name = "classInput";
            classInput.Size = new Size(145, 21);
            classInput.TabIndex = 8;
            // 
            // classNamesList
            // 
            classNamesList.Font = new Font("Angry Birds Movie", 8.25F);
            classNamesList.FormattingEnabled = true;
            classNamesList.Location = new Point(12, 73);
            classNamesList.Name = "classNamesList";
            classNamesList.Size = new Size(202, 199);
            classNamesList.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Angry Birds Movie", 8.25F);
            label1.Location = new Point(14, 331);
            label1.Name = "label1";
            label1.Size = new Size(122, 11);
            label1.TabIndex = 12;
            label1.Text = "Balancing Data Path";
            // 
            // checkAll
            // 
            checkAll.Font = new Font("Angry Birds Movie", 8.25F);
            checkAll.Location = new Point(14, 295);
            checkAll.Name = "checkAll";
            checkAll.Size = new Size(74, 23);
            checkAll.TabIndex = 13;
            checkAll.Text = "Check All";
            checkAll.UseVisualStyleBackColor = true;
            checkAll.Click += checkButton_click;
            // 
            // selectBalancingData
            // 
            selectBalancingData.Font = new Font("Angry Birds Movie", 8.25F);
            selectBalancingData.Location = new Point(127, 327);
            selectBalancingData.Name = "selectBalancingData";
            selectBalancingData.Size = new Size(64, 21);
            selectBalancingData.TabIndex = 14;
            selectBalancingData.Text = "Select Path";
            selectBalancingData.UseVisualStyleBackColor = true;
            selectBalancingData.Click += selectBalancingData_click;
            // 
            // balancingDataPath
            // 
            balancingDataPath.Font = new Font("Bahnschrift Condensed", 9F);
            balancingDataPath.Location = new Point(14, 345);
            balancingDataPath.Name = "balancingDataPath";
            balancingDataPath.Size = new Size(400, 32);
            balancingDataPath.TabIndex = 15;
            // 
            // decode
            // 
            decode.Font = new Font("Angry Birds Movie", 8.25F);
            decode.Location = new Point(224, 208);
            decode.Name = "decode";
            decode.Size = new Size(178, 48);
            decode.TabIndex = 16;
            decode.Text = "Decode Balancing Data";
            decode.UseVisualStyleBackColor = true;
            decode.Click += decode_Click;
            // 
            // encodeClassList
            // 
            encodeClassList.Font = new Font("Angry Birds Movie", 8.25F);
            encodeClassList.FormattingEnabled = true;
            encodeClassList.Location = new Point(428, 73);
            encodeClassList.Name = "encodeClassList";
            encodeClassList.Size = new Size(202, 199);
            encodeClassList.TabIndex = 18;
            // 
            // encode
            // 
            encode.Font = new Font("Angry Birds Movie", 8.25F);
            encode.Location = new Point(644, 208);
            encode.Name = "encode";
            encode.Size = new Size(178, 48);
            encode.TabIndex = 28;
            encode.Text = "Encode Balancing Data";
            encode.UseVisualStyleBackColor = true;
            encode.Click += encode_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Angry Birds Movie", 8.25F);
            textBox1.Location = new Point(653, 274);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(145, 20);
            textBox1.TabIndex = 26;
            // 
            // addEncode
            // 
            addEncode.Font = new Font("Angry Birds Movie", 8.25F);
            addEncode.Location = new Point(803, 274);
            addEncode.Name = "addEncode";
            addEncode.Size = new Size(36, 21);
            addEncode.TabIndex = 25;
            addEncode.Text = "Add";
            addEncode.UseVisualStyleBackColor = true;
            // 
            // outputBalancingPath
            // 
            outputBalancingPath.Font = new Font("Bahnschrift Condensed", 9F);
            outputBalancingPath.Location = new Point(428, 345);
            outputBalancingPath.Name = "outputBalancingPath";
            outputBalancingPath.Size = new Size(411, 32);
            outputBalancingPath.TabIndex = 32;
            // 
            // selectOutputBalancing
            // 
            selectOutputBalancing.Font = new Font("Angry Birds Movie", 8.25F);
            selectOutputBalancing.Location = new Point(566, 327);
            selectOutputBalancing.Name = "selectOutputBalancing";
            selectOutputBalancing.Size = new Size(64, 21);
            selectOutputBalancing.TabIndex = 31;
            selectOutputBalancing.Text = "Select Path";
            selectOutputBalancing.UseVisualStyleBackColor = true;
            selectOutputBalancing.Click += button2_Click;
            // 
            // checkAll2
            // 
            checkAll2.Font = new Font("Angry Birds Movie", 8.25F);
            checkAll2.Location = new Point(428, 301);
            checkAll2.Name = "checkAll2";
            checkAll2.Size = new Size(74, 23);
            checkAll2.TabIndex = 30;
            checkAll2.Text = "Check All";
            checkAll2.UseVisualStyleBackColor = true;
            checkAll2.Click += checkAll2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Angry Birds Movie", 8.25F);
            label3.Location = new Point(428, 334);
            label3.Name = "label3";
            label3.Size = new Size(122, 11);
            label3.TabIndex = 29;
            label3.Text = "Balancing Data Path";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("AngryBirds", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(172, 55);
            label4.TabIndex = 33;
            label4.Text = "DECODE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("AngryBirds", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(428, 15);
            label5.Name = "label5";
            label5.Size = new Size(171, 55);
            label5.TabIndex = 34;
            label5.Text = "ENCODE";
            // 
            // class6
            // 
            class6.Font = new Font("Angry Birds Movie", 8.25F);
            class6.Location = new Point(644, 127);
            class6.Name = "class6";
            class6.Size = new Size(86, 21);
            class6.TabIndex = 39;
            class6.Text = "1.0.14 Classes";
            class6.UseVisualStyleBackColor = true;
            class6.Click += class6_Click;
            // 
            // classes4
            // 
            classes4.Font = new Font("Angry Birds Movie", 8.25F);
            classes4.Location = new Point(644, 73);
            classes4.Name = "classes4";
            classes4.Size = new Size(86, 21);
            classes4.TabIndex = 37;
            classes4.Text = "3.0.1 Classes";
            classes4.UseVisualStyleBackColor = true;
            classes4.Click += classes4_Click;
            // 
            // classes5
            // 
            classes5.Font = new Font("Angry Birds Movie", 8.25F);
            classes5.Location = new Point(644, 100);
            classes5.Name = "classes5";
            classes5.Size = new Size(86, 21);
            classes5.TabIndex = 35;
            classes5.Text = "2.0.0 Classes";
            classes5.UseVisualStyleBackColor = true;
            classes5.Click += classes5_Click;
            // 
            // folder
            // 
            folder.AutoSize = true;
            folder.Font = new Font("Angry Birds Movie", 8.25F);
            folder.Location = new Point(14, 381);
            folder.Name = "folder";
            folder.Size = new Size(80, 11);
            folder.TabIndex = 41;
            folder.Text = "Output Folder";
            // 
            // selectOutput
            // 
            selectOutput.Font = new Font("Angry Birds Movie", 8.25F);
            selectOutput.Location = new Point(127, 374);
            selectOutput.Name = "selectOutput";
            selectOutput.Size = new Size(64, 21);
            selectOutput.TabIndex = 42;
            selectOutput.Text = "Select Output";
            selectOutput.UseVisualStyleBackColor = true;
            selectOutput.Click += selectOutput_Click;
            // 
            // outputPath
            // 
            outputPath.Font = new Font("Bahnschrift Condensed", 9F);
            outputPath.Location = new Point(14, 397);
            outputPath.Name = "outputPath";
            outputPath.Size = new Size(400, 34);
            outputPath.TabIndex = 43;
            // 
            // inputPath
            // 
            inputPath.Font = new Font("Bahnschrift Condensed", 9F);
            inputPath.Location = new Point(428, 397);
            inputPath.Name = "inputPath";
            inputPath.Size = new Size(411, 39);
            inputPath.TabIndex = 46;
            // 
            // selectInput
            // 
            selectInput.Font = new Font("Angry Birds Movie", 8.25F);
            selectInput.Location = new Point(541, 374);
            selectInput.Name = "selectInput";
            selectInput.Size = new Size(64, 21);
            selectInput.TabIndex = 45;
            selectInput.Text = "Select Output";
            selectInput.UseVisualStyleBackColor = true;
            selectInput.Click += selectInput_Click;
            // 
            // input
            // 
            input.AutoSize = true;
            input.Font = new Font("Angry Birds Movie", 8.25F);
            input.Location = new Point(428, 381);
            input.Name = "input";
            input.Size = new Size(71, 11);
            input.TabIndex = 44;
            input.Text = "Input Folder";
            // 
            // events3
            // 
            events3.Font = new Font("Angry Birds Movie", 8.25F);
            events3.Location = new Point(644, 154);
            events3.Name = "events3";
            events3.Size = new Size(86, 21);
            events3.TabIndex = 49;
            events3.Text = "Events";
            events3.UseVisualStyleBackColor = true;
            events3.Click += events3_Click_1;
            // 
            // balancingNames
            // 
            balancingNames.Font = new Font("Angry Birds Movie", 8.25F);
            balancingNames.Location = new Point(12, 434);
            balancingNames.Name = "balancingNames";
            balancingNames.Size = new Size(213, 23);
            balancingNames.TabIndex = 51;
            balancingNames.Text = "Get Class Names from Balancing";
            balancingNames.UseVisualStyleBackColor = true;
            balancingNames.Click += balancingNames_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Angry Birds Movie", 8.25F);
            button1.Location = new Point(224, 181);
            button1.Name = "button1";
            button1.Size = new Size(86, 21);
            button1.TabIndex = 52;
            button1.Text = "Clear All";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Angry Birds Movie", 8.25F);
            button2.Location = new Point(644, 181);
            button2.Name = "button2";
            button2.Size = new Size(86, 21);
            button2.TabIndex = 53;
            button2.Text = "Clear All";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // import1
            // 
            import1.Font = new Font("Angry Birds Movie", 8.25F);
            import1.Location = new Point(316, 181);
            import1.Name = "import1";
            import1.Size = new Size(86, 21);
            import1.TabIndex = 54;
            import1.Text = "Import List";
            import1.UseVisualStyleBackColor = true;
            import1.Click += import1_Click;
            // 
            // import2
            // 
            import2.Font = new Font("Angry Birds Movie", 8.25F);
            import2.Location = new Point(736, 181);
            import2.Name = "import2";
            import2.Size = new Size(86, 21);
            import2.TabIndex = 55;
            import2.Text = "Import List";
            import2.UseVisualStyleBackColor = true;
            import2.Click += import2_Click;
            // 
            // DecoderForm
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 469);
            Controls.Add(import2);
            Controls.Add(import1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(balancingNames);
            Controls.Add(events3);
            Controls.Add(inputPath);
            Controls.Add(selectInput);
            Controls.Add(input);
            Controls.Add(outputPath);
            Controls.Add(selectOutput);
            Controls.Add(folder);
            Controls.Add(class6);
            Controls.Add(classes4);
            Controls.Add(classes5);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(outputBalancingPath);
            Controls.Add(selectOutputBalancing);
            Controls.Add(checkAll2);
            Controls.Add(label3);
            Controls.Add(encode);
            Controls.Add(textBox1);
            Controls.Add(addEncode);
            Controls.Add(encodeClassList);
            Controls.Add(decode);
            Controls.Add(balancingDataPath);
            Controls.Add(selectBalancingData);
            Controls.Add(checkAll);
            Controls.Add(label1);
            Controls.Add(classNamesList);
            Controls.Add(classInput);
            Controls.Add(customClass);
            Controls.Add(classes3);
            Controls.Add(events1);
            Controls.Add(classes1);
            Controls.Add(classes2);
            Font = new Font("AngryBirds", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DecoderForm";
            Text = "Balancing Data Decoder";
            Load += DecoderForm_Load;
            Resize += DecoderForm_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button classes2;
        private Button events1;
        private Button classes1;
        private Button classes3;
        private Button customClass;
        private OpenFileDialog pickBalancing;
        private OpenFileDialog pickClassNames;
        private TextBox classInput;
        private CheckedListBox classNamesList;
        private Label label1;
        private Button checkAll;
        private Button selectBalancingData;
        private Label balancingDataPath;
        private Button decode;
        private Button selectOutputBalancing;
        private CheckedListBox encodeClassList;
        private Button encode;
        private TextBox textBox1;
        private Button addEncode;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Label outputBalancingPath;
        private Button checkAll2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button classes6;
        private Button classes4;
        private Button classes5;
        private Button class6;
        private Label folder;
        private Button selectOutput;
        private Label outputPath;
        private Label inputPath;
        private Button selectInput;
        private Label input;
        private FolderBrowserDialog selectOutputFolder;
        private FolderBrowserDialog folderBrowserDialog1;
        private FolderBrowserDialog selectInputFolder;
        private Button events3;
        private Button balancingNames;
        private Button button1;
        private Button button2;
        private Button import1;
        private Button import2;
    }
}