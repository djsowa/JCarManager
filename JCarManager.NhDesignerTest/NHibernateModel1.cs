using System;
using System.Collections.Generic;
using NHibernate.Cfg;

namespace JCarManager.NhDesignerTest
{
  [System.CodeDom.Compiler.GeneratedCode("NHibernateModelGenerator", "1.0.0.0")]
  public partial class Test
  {
    public virtual int TestId { get; set; }
    public virtual System.Nullable<System.DateTime> Date { get; set; }
    public virtual string Name { get; set; }

    public virtual Test2 Test2 { get; set; }

    static partial void CustomizeMappingDocument(System.Xml.Linq.XDocument mappingDocument);

    internal static System.Xml.Linq.XDocument MappingXml
    {
      get
      {
        var mappingDocument = System.Xml.Linq.XDocument.Parse(@"<?xml version='1.0' encoding='utf-8' ?>
<hibernate-mapping xmlns='urn:nhibernate-mapping-2.2'
                   assembly='" + typeof(Test).Assembly.GetName().Name + @"'
                   namespace='JCarManager.NhDesignerTest'
                   >
  <class name='Test'
         table='`Test`'
         >
    <id name='TestId'
        column='`TestId`'
        >
      <generator class='identity'>
      </generator>
    </id>
    <property name='Date'
              column='`Date`'
              />
    <property name='Name'
              column='`Name`'
              />
    <one-to-one name='Test2'
                class='Test2'
                cascade = 'save-update'
                />
  </class>
</hibernate-mapping>");
        CustomizeMappingDocument(mappingDocument);
        return mappingDocument;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCode("NHibernateModelGenerator", "1.0.0.0")]
  public partial class Test2
  {
    public virtual int Test2Id { get; set; }
    public virtual System.DateTime Date { get; set; }

    public virtual Test Test { get; set; }

    static partial void CustomizeMappingDocument(System.Xml.Linq.XDocument mappingDocument);

    internal static System.Xml.Linq.XDocument MappingXml
    {
      get
      {
        var mappingDocument = System.Xml.Linq.XDocument.Parse(@"<?xml version='1.0' encoding='utf-8' ?>
<hibernate-mapping xmlns='urn:nhibernate-mapping-2.2'
                   assembly='" + typeof(Test2).Assembly.GetName().Name + @"'
                   namespace='JCarManager.NhDesignerTest'
                   >
  <class name='Test2'
         table='`Test2`'
         >
    <id name='Test2Id'
        column='`Test2Id`'
        >
      <generator class='identity'>
      </generator>
    </id>
    <property name='Date'
              column='`Date`'
              />
    <one-to-one name='Test'
                class='Test'
                cascade = 'save-update'
                />
  </class>
</hibernate-mapping>");
        CustomizeMappingDocument(mappingDocument);
        return mappingDocument;
      }
    }
  }


  /// <summary>
  /// Provides a NHibernate configuration object containing mappings for this model.
  /// </summary>
  public static class ConfigurationHelper
  {
    /// <summary>
    /// Creates a NHibernate configuration object containing mappings for this model.
    /// </summary>
    /// <returns>A NHibernate configuration object containing mappings for this model.</returns>
    public static Configuration CreateConfiguration()
    {
      var configuration = new Configuration();
      configuration.Configure();
      ApplyConfiguration(configuration);
      return configuration;
    }

    /// <summary>
    /// Adds mappings for this model to a NHibernate configuration object.
    /// </summary>
    /// <param name="configuration">A NHibernate configuration object to which to add mappings for this model.</param>
    public static void ApplyConfiguration(Configuration configuration)
    {
      configuration.AddXml(ModelMappingXml.ToString());
      configuration.AddXml(Test.MappingXml.ToString());
      configuration.AddXml(Test2.MappingXml.ToString());
      configuration.AddAssembly(typeof(ConfigurationHelper).Assembly);
    }

    /// <summary>
    /// Provides global mappings not associated with a specific entity.
    /// </summary>
    public static System.Xml.Linq.XDocument ModelMappingXml
    {
      get
      {
        var mappingDocument = System.Xml.Linq.XDocument.Parse(@"<?xml version='1.0' encoding='utf-8' ?>
<hibernate-mapping xmlns='urn:nhibernate-mapping-2.2'
                   assembly='" + typeof(ConfigurationHelper).Assembly.GetName().Name + @"'
                   namespace='JCarManager.NhDesignerTest'
                   >
</hibernate-mapping>");
        return mappingDocument;
      }
    }
  }
}
