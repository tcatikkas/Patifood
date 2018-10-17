using PatifoodDataModel.Attributes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PatifoodDataModel.Helper
{
    public static class DbContextUtil
    {
        public static void SetDefaultValue(DbContext ctx, string tableName, string fieldName, string defaultValue)
        {
            var cmdStr = string.Format(
                (
                    "IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_{0}_{1}]') AND type = 'D') " +
                    " BEGIN  ALTER TABLE [dbo].[{0}] ADD  CONSTRAINT [DF_{0}_{1}]  DEFAULT ({2}) FOR [{1}]  END"
                ),
                tableName, fieldName, defaultValue
            );
            try
            {

                ctx.Database.ExecuteSqlCommand(cmdStr);
            }
            catch (Exception)
            {

            }
        }




        public static string GetTableName(Type _type)
        {
            var attr = _type.GetCustomAttributes(typeof(TableWithDefaultValue), true);
            return (attr.Length > 0) ? ((TableWithDefaultValue)attr[0]).TableName : null;
        }

        //public static List<Type> GetClasses(Type baseType)
        //{
        //    return Assembly.GetCallingAssembly().GetTypes().Where(type =>
        //        type.BaseType.Equals(baseType) &&
        //        type.Namespace.Contains("ProcessUI.DataModel.Models")
        //        ).ToList();

        //}


        public static void ApplyDbAttributesToDb(DbContext ctx)
        {

            //tum entiti classlarini al
            var allDbEntities = GetTypesWithAttribute(typeof(TableWithDefaultValue), ctx);

            //her biri icin commandlari isle
            foreach (var item in allDbEntities)
            {
                processDbAttributes(ctx, item);
            }
        }


        public static void processDbAttributes(DbContext ctx, Type entiti)
        {
            //BaseDbEntiti yi bul onda islenmis attributelari tekrar islememen lazim cunku
            var exEntiti = getDiffType(entiti);


            var exprops = exEntiti.GetProperties();
            var props = entiti.GetProperties().Where(e => !exprops.Any(k => k.Name == e.Name));

            //TODO: eger default var da kaldirilmissa onlar ayiklanmali

            //islenmemis default attributelari isle
            processDefaultAttributes(ctx, entiti, props);

        }

        public static void processDefaultAttributes(DbContext ctx, Type entiti, IEnumerable<PropertyInfo> props)
        {
            var tbname = GetTableName(entiti);
            foreach (var item in props)
            {
                var attr = item.GetCustomAttributes(typeof(DbDefaultValue), false).FirstOrDefault() as DbDefaultValue;
                if (attr == null)
                    continue;
                SetDefaultValue(ctx, tbname, item.Name, attr.DefaultValue);
            }
        }


        public static Type getDiffType(Type t)
        {
            var t2 = t.BaseType;
            while (t2 != typeof(object))
            {
                if (Attribute.GetCustomAttribute(t2, typeof(TableWithDefaultValue)) != null) break;
                t2 = t2.BaseType;
            }

            return t2;
        }


        public static IEnumerable<Type> GetTypesWithAttribute(Type attribute, DbContext ctx)
        {
            var assembly = Assembly.GetAssembly(ctx.GetType());
            foreach (Type type in assembly.GetTypes())
            {
                if (type.GetCustomAttributes(attribute, true).Length > 0)
                {
                    yield return type;
                }
            }
        }


    }
}
