using DotFuzzy;

namespace Uy_FuzzyLogic
{
    public partial class Form1 : Form
    {
        FuzzyEngine fe;
        MembershipFunctionCollection weight, dirt, machineSpeed;
        LinguisticVariable myWeight , myDirt, myMachineSpeed;
        FuzzyRuleCollection myRules;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            myWeight.InputValue = Convert.ToDouble(lbl_weight.Text);
            myWeight.Fuzzify("Medium");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            myDirt.InputValue = Convert.ToDouble(lbl_dirt.Text);
            myDirt.Fuzzify("Dirty");
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            lbl_weight.Text = trackBar1.Value.ToString();
        }

        private void TrackBar2_Scroll(object sender, EventArgs e)
        {
            lbl_dirt.Text = trackBar2.Value.ToString();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            setFuzzyEngine();
            fe.Consequent = "MACHINESPEED";
            ans.Text = "" + fe.Defuzzify();
        }

        public void setMembers()
        {
            weight = new MembershipFunctionCollection();
            weight.Add(new MembershipFunction("Light", 0.0, 0.0, 10.0, 19.0));
            weight.Add(new MembershipFunction("Medium", 20.0, 20.0, 25.0, 25.0));
            weight.Add(new MembershipFunction("Heavy", 26.0, 30.0, 50.0, 50.0));
            myWeight = new LinguisticVariable("WEIGHT", weight);

            dirt = new MembershipFunctionCollection();
            dirt.Add(new MembershipFunction("Clean", 0.0, 0.0, 3.0, 3.0));
            dirt.Add(new MembershipFunction("Medium", 4.0, 5.0, 5.0, 5.0));
            dirt.Add(new MembershipFunction("Dirty", 6.0, 6.0, 10, 10.0));
            myDirt = new LinguisticVariable("DIRTY", dirt);

            machineSpeed = new MembershipFunctionCollection();
            machineSpeed.Add(new MembershipFunction("Slow", 0.0, 0.0, 10.0, 30.0));
            machineSpeed.Add(new MembershipFunction("Medium", 25.0, 45.0, 50.0, 65.0));
            machineSpeed.Add(new MembershipFunction("Fast", 60.0, 65.0, 100.0, 100.0));
            myMachineSpeed = new LinguisticVariable("MACHINESPEED", machineSpeed);

        }

        public void setRules()
        {
            myRules = new FuzzyRuleCollection();
            myRules.Add(new FuzzyRule("IF (WEIGHT IS Light) AND (DIRTY IS Clean)  THEN MACHINESPEED IS Slow"));
            myRules.Add(new FuzzyRule("IF (WEIGHT IS Light) AND (DIRTY IS Medium)  THEN MACHINESPEED IS Slow"));
            myRules.Add(new FuzzyRule("IF (WEIGHT IS Light) AND (DIRTY IS Dirty)  THEN MACHINESPEED IS Medium"));
            myRules.Add(new FuzzyRule("IF (WEIGHT IS Medium) AND (DIRTY IS Clean)  THEN MACHINESPEED IS Medium"));
            myRules.Add(new FuzzyRule("IF (WEIGHT IS Medium) AND (DIRTY IS Medium)  THEN MACHINESPEED IS Medium"));
            myRules.Add(new FuzzyRule("IF (WEIGHT IS Medium) AND (DIRTY IS Dirty)  THEN MACHINESPEED IS Fast"));
            myRules.Add(new FuzzyRule("IF (WEIGHT IS Heavy) AND (DIRTY IS Clean)  THEN MACHINESPEED IS Medium"));
            myRules.Add(new FuzzyRule("IF (WEIGHT IS Heavy) AND (DIRTY IS Medium)  THEN MACHINESPEED IS Fast"));
            myRules.Add(new FuzzyRule("IF (WEIGHT IS Heavy) AND (DIRTY IS Dirty)  THEN MACHINESPEED IS Fast"));
        }

        public void setFuzzyEngine()
        {
            fe = new FuzzyEngine();
            fe.LinguisticVariableCollection.Add(myWeight);
            fe.LinguisticVariableCollection.Add(myDirt);
            fe.LinguisticVariableCollection.Add(myMachineSpeed);
            fe.FuzzyRuleCollection = myRules;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            setMembers();
            setRules();
        }
        
    }
}