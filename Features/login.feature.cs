﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by Reqnroll (https://www.reqnroll.net/).
//      Reqnroll Version:2.0.0.0
//      Reqnroll Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace ReqnrollProject1.Features
{
    using Reqnroll;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Reqnroll", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("login")]
    public partial class LoginFeature
    {
        
        private global::Reqnroll.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private static global::Reqnroll.FeatureInfo featureInfo = new global::Reqnroll.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "login", "A short summary of the feature", global::Reqnroll.ProgrammingLanguage.CSharp, featureTags);
        
#line 1 "login.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public static async System.Threading.Tasks.Task FeatureSetupAsync()
        {
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public static async System.Threading.Tasks.Task FeatureTearDownAsync()
        {
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public async System.Threading.Tasks.Task TestInitializeAsync()
        {
            testRunner = global::Reqnroll.TestRunnerManager.GetTestRunnerForAssembly(featureHint: featureInfo);
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Equals(featureInfo) == false)))
            {
                await testRunner.OnFeatureEndAsync();
            }
            if ((testRunner.FeatureContext == null))
            {
                await testRunner.OnFeatureStartAsync(featureInfo);
            }
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public async System.Threading.Tasks.Task TestTearDownAsync()
        {
            await testRunner.OnScenarioEndAsync();
            global::Reqnroll.TestRunnerManager.ReleaseTestRunner(testRunner);
        }
        
        public void ScenarioInitialize(global::Reqnroll.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public async System.Threading.Tasks.Task ScenarioStartAsync()
        {
            await testRunner.OnScenarioStartAsync();
        }
        
        public async System.Threading.Tasks.Task ScenarioCleanupAsync()
        {
            await testRunner.CollectScenarioErrorsAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Login with ModelTableData Credentials")]
        [NUnit.Framework.CategoryAttribute("tag1")]
        public async System.Threading.Tasks.Task LoginWithModelTableDataCredentials()
        {
            string[] tagsOfScenario = new string[] {
                    "tag1"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Login with ModelTableData Credentials", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 6
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 7
 await testRunner.GivenAsync("I have accessed the Swag Labs Login Page", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
                global::Reqnroll.Table table1 = new global::Reqnroll.Table(new string[] {
                            "username",
                            "password"});
                table1.AddRow(new string[] {
                            "standard_user",
                            "secret_sauce"});
#line 8
 await testRunner.WhenAsync("I enter the Credential Details", ((string)(null)), table1, "When ");
#line hidden
#line 11
 await testRunner.AndAsync("I Click Login Button", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 12
 await testRunner.ThenAsync("I should Navigate to the Product Page", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
                global::Reqnroll.Table table2 = new global::Reqnroll.Table(new string[] {
                            "product1",
                            "product2"});
                table2.AddRow(new string[] {
                            "Sauce Labs Backpack",
                            "Sauce Labs Bike Light"});
#line 13
 await testRunner.WhenAsync("I Add Two products to baskets", ((string)(null)), table2, "When ");
#line hidden
#line 16
 await testRunner.AndAsync("I Click on the Shopping Cart to view the Basket", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 17
 await testRunner.ThenAsync("confirm the total number of products in the basket is 2", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
                global::Reqnroll.Table table3 = new global::Reqnroll.Table(new string[] {
                            "product1",
                            "product2"});
                table3.AddRow(new string[] {
                            "Sauce Labs Backpack",
                            "Sauce Labs Bike Light"});
#line 18
 await testRunner.AndAsync("I Verify 2 Product Names in the baskets as", ((string)(null)), table3, "And ");
#line hidden
#line 21
 await testRunner.AndAsync("Logout.", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
    }
}
#pragma warning restore
#endregion
