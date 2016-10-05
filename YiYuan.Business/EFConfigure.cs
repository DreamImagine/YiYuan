using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using YiYuan.Entity;

namespace YiYuan.Business
{
    /// <summary>
    /// ef 自定义配置类
    /// </summary>
    public static class EFConfigure
    {
        /// <summary>
        /// ef 自定义配置类 初始化
        /// </summary>
        public static void Init()
        {
            // 禁止对 __MigrationHistory访问
            Database.SetInitializer<DataBaseContext>(null);

            using (var dbcontext = new DataBaseContext())
            {
                var objectContext = ((IObjectContextAdapter)dbcontext).ObjectContext;
                var mappingCollection = (StorageMappingItemCollection)objectContext.MetadataWorkspace.GetItemCollection(DataSpace.CSSpace);
                mappingCollection.GenerateViews(new List<EdmSchemaError>());
                //对程序中定义的所有DbContext逐一进行这个操作
            }
        }
    }
}
