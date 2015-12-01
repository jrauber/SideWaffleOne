using Microsoft.VisualStudio.TemplateWizard;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Wizard
{
    public class TgifWizard : IWizard
    { 
        public static Dictionary<string, string> GlobalDictionary = new Dictionary<string, string>();

        public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
        {
            try
            {
                WizardForm frm = new WizardForm();

                frm.ShowDialog();

                if (frm.Value.DayOfWeek == DayOfWeek.Friday)
                {
                    replacementsDictionary.Add("$tgif$", "IT IS FRIDAY - TGIF YEAH ");
                }
                else
                {
                    replacementsDictionary.Add("$tgif$", "NOT YET FRIDAY - TGIF MUST WAIT");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void BeforeOpeningFile(EnvDTE.ProjectItem projectItem)
        {
        }

        public void ProjectFinishedGenerating(EnvDTE.Project project)
        {
        }

        public void ProjectItemFinishedGenerating(EnvDTE.ProjectItem projectItem)
        {
        }

        public void RunFinished()
        {
        }

        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }
    }
}

