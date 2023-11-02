using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 绩效考核系统 {
    public class FrmFactory<T> {
        //private static FrmBaseManager frmBaseManager;
        //private static FrmUserManager frmUserManager;
        //private static FrmNone frmNone;
        private static Form frmForm;
        private static List<Form> forms = new List<Form>();


        //public static Form CreatForm(int index) {
        //    HideFormAll();
        //    switch (index) {
        //        case 0:
        //            if (frmUserManager == null) {
        //                frmUserManager = new FrmUserManager();
        //                forms.Add(frmUserManager);
        //            }
        //            frmForm = frmUserManager;

        //            break;
        //        case 1:
        //            if (frmBaseManager == null) {
        //                frmBaseManager = new FrmBaseManager();
        //                forms.Add(frmBaseManager);
        //            }
        //            frmForm = frmBaseManager;
        //            break;
        //        default:
        //            if (frmNone == null) { 
        //                frmNone = new FrmNone();
        //                forms.Add(frmNone);
        //            }
        //            frmForm = frmNone; break;
        //    }
        //    return frmForm;
        //}

        private static List<Type> types;
        static FrmFactory() {
            Assembly assembly = Assembly.LoadFrom("绩效考核系统.exe");
            types = assembly.GetTypes().ToList();
        }
        public static Form CreatForm(string formName) {
            HideFormAll();
            Form form =  forms.Find(m => m.Name == formName);
            if (form == null) {
                Type type = types.Find(m => m.Name == formName);
                form = (Form)Activator.CreateInstance(type);
            }
            forms.Add(form);
            return form;
        }
        public static void HideFormAll() {
            foreach(Form form in forms) { form.Hide();}
        }
    }
}
