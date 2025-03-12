using ABEpicBalancingDataContainerDecoder;
using Chimera.Library.Components.Interfaces;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Numerics;
using System.Reflection;

namespace BalancingDecoderFrom
{
    public partial class DecoderForm : Form
    {
        Dictionary<Control, Rectangle> ControlOriginalSizes = [];
        Dictionary<Control, Font> OriginalFonts = [];
        Rectangle FormOriginalSize;

        public DecoderForm()
        {
            InitializeComponent();
            SetCheckedListBoxes();
            classNamesList.KeyDown += ClassNamesList_KeyDown;
            classNamesList.SelectedIndexChanged += ClassNamesList_SelectedIndexChanged;
            classNamesList.ItemCheck += ClassNamesList_ItemCheck;
            encodeClassList.KeyDown += EncodeClassList_KeyDown;
            encodeClassList.SelectedIndexChanged += EncodeClassList_SelectedIndexChanged;
            encodeClassList.ItemCheck += EncodeClassList_ItemCheck;

            outputPath.Text = Directory.GetCurrentDirectory();
            selectOutputFolder.InitialDirectory = Directory.GetCurrentDirectory();
            selectInputFolder.InitialDirectory = Directory.GetCurrentDirectory();
            inputPath.Text = Directory.GetCurrentDirectory();
        }

        private void DecoderForm_Load(object sender, EventArgs e)
        {
            FormOriginalSize = Bounds;
            foreach (Control c in Controls)
            {
                ControlOriginalSizes.Add(c, c.Bounds);
                OriginalFonts.Add(c, c.Font);
            }
        }

        Rectangle GetScaledRect(Rectangle originalRect)
        {
            Vector2 ratio = new((float)Width / FormOriginalSize.Width, (float)Height / FormOriginalSize.Height);

            Vector2 newSize = new Vector2(originalRect.Width, originalRect.Height) * ratio;
            Vector2 newPos = new Vector2(originalRect.X, originalRect.Y) * ratio;

            return new((int)newPos.X, (int)newPos.Y, (int)newSize.X, (int)newSize.Y);
        }

        Font GetScaledFont(Font originalFont)
        {
            Vector2 ratio = new((float)Width / FormOriginalSize.Width, (float)Height / FormOriginalSize.Height);

            float fontSizeScaler = ratio.X > ratio.Y ? ratio.Y : ratio.X;
            Font newFont = new(originalFont.FontFamily, originalFont.Size * fontSizeScaler, originalFont.Unit);
            return newFont;
        }

        private void DecoderForm_Resize(object sender, EventArgs e)
        {
            foreach ((var control, var rect) in ControlOriginalSizes)
            {
                control.Bounds = GetScaledRect(rect);
                control.Font = GetScaledFont(OriginalFonts[control]);
            }
        }

        CheckedListBox selectedList = null!;

        private void SetCheckedListBoxes()
        {
            classNamesList = (CheckedListBox)Controls.Find("classNamesList", false)[0];
            encodeClassList = (CheckedListBox)Controls.Find("encodeClassList", false)[0];
        }

        private void ClassNamesList_ItemCheck(object? sender, ItemCheckEventArgs e)
        {
            if (!allSelected(classNamesList))
            {
                checkAll.Text = "Check All";
            }
            else
            {
                checkAll.Text = "Check None";
            }
        }
        private void EncodeClassList_ItemCheck(object? sender, ItemCheckEventArgs e)
        {
            if (!allSelected(encodeClassList))
            {
                checkAll2.Text = "Check All";
            }
            else
            {
                checkAll2.Text = "Check None";
            }
        }

        string[] classNames1 = [
    "BannerBalancingData",
    "BannerItemBalancingData",
    "BasicItemBalancingData",
    "BattleBalancingData",
    "BattleHintBalancingData",
    "BattleParticipantTableBalancingData",
    "BirdBalancingData",
    "BossBalancingData",
    "BuyableShopOfferBalancingData",
    "ChronicleCaveBattleBalancingData",
    "ChronicleCaveBattleParticipantTableBalancingData",
    "ChronicleCaveFloorBalancingData",
    "ChronicleCaveHotspotBalancingData",
    "ClassItemBalancingData",
    "ClassSkinBalancingData",
    "ClientConfigBalancingData",
    "CollectionGroupBalancingData",
    "ConditionalInventoryBalancingData",
    "ConsumableItemBalancingData",
    "CraftingItemBalancingData",
    "CraftingRecipeBalancingData",
    "CustomMessageBalancingData",
    "DailyLoginGiftsBalancingData",
    "EnchantingBalancingData",
    "EquipmentBalancingData",
    "EventItemBalancingData",
    "ExperienceLevelBalancingData",
    "ExperienceMasteryBalancingData",
    "ExperienceScalingBalancingData",
    "GachaShopOfferBalancingData",
    "GameConstantsBalancingData",
    "HotspotBalancingData",
    "InventoryBalancingData",
    "LoadingHintBalancingData",
    "LootTableBalancingData",
    "MasteryItemBalancingData",
    "MiniCampaignBalancingData",
    "PigBalancingData",
    "PigTypePowerLevelBalancingData",
    "PowerLevelBalancingData",
    "PremiumShopOfferBalancingData",
    "PvPObjectivesBalancingData",
    "ResourceCostPerLevelBalancingData",
    "SalesManagerBalancingData",
    "ScoreBalancingData",
    "SetFusionBalancingData",
    "ShopBalancingData",
    "SkillBalancingData",
    "SocialEnvironmentBalancingData",
    "SplashScreenBalancingData",
    "ThirdPartyIdBalancingData"
        ];

        string[] classNames2 =
            [
                "AchievementBalancingData",
                "BannerBalancingData",
                "BannerItemBalancingData",
                "BasicItemBalancingData",
                "BattleBalancingData",
                "BattleHintBalancingData",
                "BattleParticipantTableBalancingData",
                "BirdBalancingData",
                "BonusPerFriendBalancingData",
                "BossBalancingData",
                "BuyableShopOfferBalancingData",
                "ChronicleCaveBattleBalancingData",
                "ChronicleCaveBattleParticipantTableBalancingData",
                "ChronicleCaveFloorBalancingData",
                "ChronicleCaveHotspotBalancingData",
                "ClassItemBalancingData",
                "ClassSkinBalancingData",
                "ClientConfigBalancingData",
                "CollectionGroupBalancingData",
                "ConditionalInventoryBalancingData",
                "ConsumableItemBalancingData",
                "CraftingItemBalancingData",
                "CraftingRecipeBalancingData",
                "CustomMessageBalancingData",
                "DailyLoginGiftsBalancingData",
                "EnchantingBalancingData",
                "EquipmentBalancingData",
                "EventItemBalancingData",
                "EventPopupBalancingData",
                "ExperienceLevelBalancingData",
                "ExperienceMasteryBalancingData",
                "ExperienceScalingBalancingData",
                "GachaShopOfferBalancingData",
                "GlobalDifficultyBalancingData",
                "HotspotBalancingData",
                "InventoryBalancingData",
                "LoadingHintBalancingData",
                "LootTableBalancingData",
                "MasteryItemBalancingData",
                "MiniCampaignBalancingData",
                "PigBalancingData",
                "PigTypePowerLevelBalancingData",
                "PowerLevelBalancingData",
                "PremiumShopOfferBalancingData",
                "PvPAIBalancingData",
                "PvPObjectivesBalancingData",
                "ResourceCostPerLevelBalancingData",
                "SalesManagerBalancingData",
                "ScoreBalancingData",
                "ShopBalancingData",
                "SkillBalancingData",
                "SocialEnvironmentBalancingData",
                "ThirdPartyIdBalancingData",
                "WorldBalancingData"
        ];
        string[] classNames3 = [
    "BasicItemBalancingData",
    "BattleBalancingData",
    "BattleParticipantTableBalancingData",
    "BirdBalancingData",
    "BonusPerFriendBalancingData",
    "ChronicleCaveBattleBalancingData",
    "ChronicleCaveBattleParticipantTableBalancingData",
    "ChronicleCaveFloorBalancingData",
    "ChronicleCaveHotspotBalancingData",
    "ClassItemBalancingData",
    "ClientConfigBalancingData",
    "ConditionalInventoryBalancingData",
    "ConsumableItemBalancingData",
    "CraftingItemBalancingData",
    "CraftingRecipeBalancingData",
    "CustomMessageBalancingData",
    "EquipmentBalancingData",
    "ExperienceLevelBalancingData",
    "GlobalDifficultyBalancingData",
    "HotspotBalancingData",
    "InventoryBalancingData",
    "LoadingHintBalancingData",
    "LootTableBalancingData",
    "PigBalancingData",
    "ResourceCostPerLevelBalancingData",
    "ScoreBalancingData",
    "ShopBalancingData",
    "ShopOfferBalancingData",
    "SkillBalancingData",
    "SocialEnvironmentBalancingData",
    "ThirdPartyIdBalancingData",
    "WorldBalancingData"
        ];

        int selectedItemIndex = -1;

        private void ClassNamesList_SelectedIndexChanged(object? sender, EventArgs e)
        {
            selectedItemIndex = classNamesList.SelectedIndex;
            selectedList = classNamesList;
        }

        private void ClassNamesList_KeyDown(object? sender, KeyEventArgs e)
        {
            if (selectedItemIndex != -1 && e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back && selectedList == classNamesList)
            {
                classNamesList.Items.RemoveAt(selectedItemIndex);
            }
        }
        private void EncodeClassList_SelectedIndexChanged(object? sender, EventArgs e)
        {
            selectedItemIndex = classNamesList.SelectedIndex;
            selectedList = encodeClassList;
        }

        private void EncodeClassList_KeyDown(object? sender, KeyEventArgs e)
        {
            if (selectedItemIndex != -1 && e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back && selectedList == encodeClassList)
            {
                encodeClassList.Items.RemoveAt(selectedItemIndex);
            }
        }

        private void SetAllItemsChecked(CheckedListBox list, bool check = true)
        {
            for (int i = 0; i < list.Items.Count; i++)
            {
                list.SetItemChecked(i, check);
            }
            if (list == classNamesList)
            {
                if (!check)
                {
                    checkAll.Text = "Check All";
                }
                else
                {
                    checkAll.Text = "Check None";
                }
            }
            else
            {
                if (!check)
                {
                    checkAll2.Text = "Check All";
                }
                else
                {
                    checkAll2.Text = "Check None";
                }
            }
        }

        private void customClass_Click(object sender, EventArgs e)
        {
            classNamesList.Items.Add(classInput.Text);
            classInput.Text = "";
        }

        private void classes1_Click(object sender, EventArgs e)
        {
            classNamesList.Items.Clear();
            classNamesList.Items.AddRange(classNames1);
            SetAllItemsChecked(classNamesList, true);
        }

        private void classes2_Click(object sender, EventArgs e)
        {
            classNamesList.Items.Clear();
            classNamesList.Items.AddRange(classNames2);
            SetAllItemsChecked(classNamesList, true);
        }

        private void classes3_Click(object sender, EventArgs e)
        {
            classNamesList.Items.Clear();
            classNamesList.Items.AddRange(classNames3);
            SetAllItemsChecked(classNamesList, true);
        }

        string[] eventNames = {
    "BonusEventBalancingData",
    "EventBalancingData",
    "EventManagerBalancingData",
    "EventPlacementBalancingData",
    "PvPSeasonManagerBalancingData"
};

        private void events1_Click(object sender, EventArgs e)
        {
            classNamesList.Items.Clear();
            classNamesList.Items.AddRange(eventNames);
            SetAllItemsChecked(classNamesList, true);
        }

        bool allSelected(CheckedListBox list) => list.Items.Count == 0 || list.Items.Count == list.CheckedItems.Count;

        private void checkButton_click(object sender, EventArgs e)
        {
            SetAllItemsChecked(classNamesList, !allSelected(classNamesList));
            if (!allSelected(classNamesList))
            {
                checkAll.Text = "Check All";
            }
            else
            {
                checkAll.Text = "Check None";
            }
        }

        private void selectBalancingData_click(object sender, EventArgs e)
        {
            var result = pickBalancing.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                balancingDataPath.Text = pickBalancing.FileName;
            }
        }

        private void importClassNames_Click(object sender, EventArgs e)
        {
            var stream = (FileStream)pickClassNames.OpenFile();
        }

        private void classes4_Click(object sender, EventArgs e)
        {

            encodeClassList.Items.Clear();
            encodeClassList.Items.AddRange(classNames1);
            SetAllItemsChecked(encodeClassList, true);
        }

        private void events3_Click(object sender, EventArgs e)
        {
            encodeClassList.Items.Clear();
            encodeClassList.Items.AddRange(eventNames);
            SetAllItemsChecked(encodeClassList, true);
        }

        private void classes5_Click(object sender, EventArgs e)
        {
            encodeClassList.Items.Clear();
            encodeClassList.Items.AddRange(classNames2);
            SetAllItemsChecked(encodeClassList, true);
        }

        private void class6_Click(object sender, EventArgs e)
        {
            encodeClassList.Items.Clear();
            encodeClassList.Items.AddRange(classNames3);
            SetAllItemsChecked(encodeClassList, true);
        }

        private void checkAll2_Click(object sender, EventArgs e)
        {
            SetAllItemsChecked(encodeClassList, !allSelected(encodeClassList));
            if (!allSelected(encodeClassList))
            {
                checkAll2.Text = "Check All";
            }
            else
            {
                checkAll2.Text = "Check None";
            }
        }

        private void selectOutput_Click(object sender, EventArgs e)
        {
            var result = selectOutputFolder.ShowDialog();
            if (result == DialogResult.OK)
            {
                outputPath.Text = selectOutputFolder.SelectedPath;
            }
        }

        private void selectInput_Click(object sender, EventArgs e)
        {
            var result = selectInputFolder.ShowDialog();
            if (result == DialogResult.OK)
            {
                inputPath.Text = selectInputFolder.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = pickBalancing.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                outputBalancingPath.Text = pickBalancing.FileName;
            }
        }

        private void decode_Click(object sender, EventArgs e)
        {
            foreach (var item in classNamesList.CheckedItems)
            {
                if (item is string name)
                {
                    BalancingDecoder.DecoderMain(["decode", name, balancingDataPath.Text, outputPath.Text]);
                }
            }
            MessageBox.Show("Balancing data has finished being decoded!", "Decoder", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void InvalidClassName(string errorText)
        {
            MessageBox.Show(errorText, "Invalid Class Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void encode_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Would you like to compress balancing data? (Takes longer)", "Decoder", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            foreach (string name in encodeClassList.CheckedItems)
            {
                string fullName = "ABH.Shared.BalancingData." + name + ".json";
                string fullPath = Path.Combine(inputPath.Text, fullName);

                BalancingDecoder.DecoderMain(["reimport", name, outputBalancingPath.Text, fullPath, outputBalancingPath.Text, (result == DialogResult.Yes).ToString()]);
            }
            MessageBox.Show("Balancing data has been successfully encoded!", "Decoder", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void balancingNames_Click(object sender, EventArgs e)
        {
            var result = pickBalancing.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                var names = BalancingDecoder.GetClassNames(pickBalancing.FileName);
                result = selectOutputFolder.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    var namesTrimed = new List<string>(names.Count);
                    names.ForEach(name => namesTrimed.Add(name.Replace("ABH.Shared.BalancingData.", "")));

                    string path = Path.Combine(selectOutputFolder.SelectedPath, $"{Path.GetFileName(pickBalancing.FileName)}_Classes.json");
                    if (File.Exists(path))
                    {
                        File.Delete(path);
                    }
                    File.WriteAllText(path, JsonConvert.SerializeObject(namesTrimed, Formatting.Indented));

                    MessageBox.Show($"Output names in {path}.", "Decoder", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void events3_Click_1(object sender, EventArgs e)
        {
            encodeClassList.Items.Clear();
            encodeClassList.Items.AddRange(eventNames);
            SetAllItemsChecked(encodeClassList, true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            classNamesList.Items.Clear();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            encodeClassList.Items.Clear();
        }

        private void import1_Click(object sender, EventArgs e)
        {
            var result = pickClassNames.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                var file = pickClassNames.FileName;

                if (file.EndsWith(".json"))
                {
                    classNamesList.Items.Clear();
                    classNamesList.Items.AddRange(JsonConvert.DeserializeObject<string[]>(File.ReadAllText(file)));
                    SetAllItemsChecked(classNamesList, true);
                }
                else
                {
                    classNamesList.Items.Clear();
                    classNamesList.Items.AddRange(File.ReadAllLines(file));
                    SetAllItemsChecked(classNamesList, true);
                }
            }
        }

        private void import2_Click(object sender, EventArgs e)
        {
            var result = pickClassNames.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                var file = pickClassNames.FileName;

                if (file.EndsWith(".json"))
                {
                    encodeClassList.Items.Clear();
                    encodeClassList.Items.AddRange(JsonConvert.DeserializeObject<string[]>(File.ReadAllText(file)));
                    SetAllItemsChecked(encodeClassList, true);
                }
                else
                {
                    encodeClassList.Items.Clear();
                    encodeClassList.Items.AddRange(File.ReadAllLines(file));
                    SetAllItemsChecked(encodeClassList, true);
                }
            }
        }

        public bool UseBalancing()
        {
            return useCustomBalancing.Checked;
        }

        private void importCustomBalancing_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Import a ABHSharedClient.dll to support custom balancing data.", this);
        }

        private void useCustomBalancing_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Use the balancing data classes in the imported module?", this);
        }

        private void importCustomBalancing_Click(object sender, EventArgs e)
        {
            try
            {
                var result = pickModule.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    var balancingModule = Assembly.LoadFile(pickModule.FileName);
                    result = pickLibraryModule.ShowDialog(this);
                    if (result == DialogResult.OK)
                    {
                        var interfaceModule = Assembly.LoadFile(pickLibraryModule.FileName);
                        List<Type> balancingData = [];
                        string outputString = $"----{DateTime.Now.ToString()}----";
                        foreach (var type in balancingModule.GetTypes())
                        {
                            if (type.GetInterfaces().Any(i => i.FullName == "Chimera.Library.Components.Interfaces.IBalancingData") && !type.IsInterface && !type.IsAbstract)
                            {

                                balancingData.Add(type);
                                outputString += type.FullName + "\n";
                            }
                        }

                        string path = Path.Combine(Directory.GetCurrentDirectory(), "importedClasses.txt");

                        if (File.Exists(path))
                        {
                            outputString = File.ReadAllText(path) + outputString;
                            File.Delete(path);
                        }

                        File.WriteAllText(path, outputString);

                        BalancingDecoder.ImportedBalancingData = balancingData;

                        MessageBox.Show("Successfully imported module! Imported type names saved in " + path + ".", "Decoder", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to import module(s)!\n{ex.Message}", "Decoder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearImportLog_Click(object sender, EventArgs e)
        {

            string path = Path.Combine(Directory.GetCurrentDirectory(), "importedClasses.txt");
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        private void openLog_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "importedClasses.txt");
            if (File.Exists(path))
            {
                Process process = new();
                process.StartInfo.FileName = path;
                process.StartInfo.UseShellExecute = true;
                process.Start();
            }
            else
            {
                MessageBox.Show("Log file doesn't exist.", "Decoder", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
