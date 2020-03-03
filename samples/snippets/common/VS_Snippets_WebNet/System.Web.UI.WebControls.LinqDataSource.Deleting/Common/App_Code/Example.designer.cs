﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1318
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[System.Data.Linq.Mapping.DatabaseAttribute(Name="C:\\USERFILES\\TOMFITZ\\VISUAL STUDIO CODENAME ORCAS\\WEBSITES\\WEBSITE4\\APP_DATA\\EXAM" +
  "PLE.MDF")]
public partial class ExampleDataContext : System.Data.Linq.DataContext {
  
  private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
  
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertProduct(Product instance);
  partial void UpdateProduct(Product instance);
  partial void DeleteProduct(Product instance);
  #endregion
  
  static ExampleDataContext() {
  }
  
  public ExampleDataContext(string connection) : 
      base(connection, mappingSource) {
    OnCreated();
  }
  
  public ExampleDataContext(System.Data.IDbConnection connection) : 
      base(connection, mappingSource) {
    OnCreated();
  }
  
  public ExampleDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
      base(connection, mappingSource) {
    OnCreated();
  }
  
  public ExampleDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
      base(connection, mappingSource) {
    OnCreated();
  }
  
  public ExampleDataContext() : 
      base(global::System.Configuration.ConfigurationManager.ConnectionStrings["ExampleConnectionString"].ConnectionString, mappingSource) {
  }
  
  public System.Data.Linq.Table<Product> Products {
    get {
      return this.GetTable<Product>();
    }
  }
}

[Table(Name="dbo.Products")]
public partial class Product : System.ComponentModel.INotifyPropertyChanged {
  
  private static PropertyChangedEventArgs emptyEventArgs = new PropertyChangedEventArgs(String.Empty);
  
  private int _ProductID = default(int);
  
  private string _Name;
  
  private string _Category;
  
  private System.Nullable<System.DateTime> _DateModified;
  
  private bool _OnSale;
  
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void OnLoaded();
    partial void OnValidate();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnCategoryChanging(string value);
    partial void OnCategoryChanged();
    partial void OnDateModifiedChanging(System.Nullable<System.DateTime> value);
    partial void OnDateModifiedChanged();
    partial void OnOnSaleChanging(bool value);
    partial void OnOnSaleChanged();
    #endregion
  
  public Product() {
    OnCreated();
  }
  
  [Column(Storage="_ProductID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
  public int ProductID {
    get {
      return this._ProductID;
    }
  }
  
  [Column(Storage="_Name", DbType="NVarChar(50)", UpdateCheck=UpdateCheck.Never)]
  public string Name {
    get {
      return this._Name;
    }
    set {
      if ((this._Name != value)) {
        this.OnNameChanging(value);
        this.SendPropertyChanging();
        this._Name = value;
        this.SendPropertyChanged();
        this.OnNameChanged();
      }
    }
  }
  
  [Column(Storage="_Category", DbType="NVarChar(50)", UpdateCheck=UpdateCheck.Never)]
  public string Category {
    get {
      return this._Category;
    }
    set {
      if ((this._Category != value)) {
        this.OnCategoryChanging(value);
        this.SendPropertyChanging();
        this._Category = value;
        this.SendPropertyChanged();
        this.OnCategoryChanged();
      }
    }
  }
  
  [Column(Storage="_DateModified", DbType="DateTime", UpdateCheck=UpdateCheck.Never)]
  public System.Nullable<System.DateTime> DateModified {
    get {
      return this._DateModified;
    }
    set {
      if ((this._DateModified != value)) {
        this.OnDateModifiedChanging(value);
        this.SendPropertyChanging();
        this._DateModified = value;
        this.SendPropertyChanged();
        this.OnDateModifiedChanged();
      }
    }
  }
  
  [Column(Storage="_OnSale")]
  public bool OnSale {
    get {
      return this._OnSale;
    }
    set {
      if ((this._OnSale != value)) {
        this.OnOnSaleChanging(value);
        this.SendPropertyChanging();
        this._OnSale = value;
        this.SendPropertyChanged();
        this.OnOnSaleChanged();
      }
    }
  }
  
  public event System.ComponentModel.PropertyChangedEventHandler PropertyChanging;
  
  public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
  
  protected virtual void SendPropertyChanging() {
    if ((this.PropertyChanging != null)) {
      this.PropertyChanging(this, emptyEventArgs);
    }
  }
  
  protected virtual void SendPropertyChanged() {
    if ((this.PropertyChanged != null)) {
      this.PropertyChanged(this, emptyEventArgs);
    }
  }
}
