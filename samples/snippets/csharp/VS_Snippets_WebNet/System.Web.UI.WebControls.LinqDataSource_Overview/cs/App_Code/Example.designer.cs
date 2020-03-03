﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1302
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

public partial class ExampleDataContext : global::System.Data.Linq.DataContext
{

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public ExampleDataContext(string connection)
        :
            base(connection)
    {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public ExampleDataContext(global::System.Data.IDbConnection connection)
        :
            base(connection)
    {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public ExampleDataContext()
        :
            base(System.Configuration.ConfigurationManager.ConnectionStrings["ExampleConnectionString"].ConnectionString)
    {
    }

    public global::System.Data.Linq.Table<Movies> Movies
    {
        get
        {
            return this.GetTable<Movies>();
        }
    }
}

[Table(Name = "dbo.Movies")]
public partial class Movies : global::System.ComponentModel.INotifyPropertyChanged
{

    private int _MovieID;

    private string _Title;

    private global::System.Nullable<global::System.DateTime> _ReleaseDate;

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public Movies()
    {
        this._MovieID = default(int);
    }

    [Column(Storage = "_MovieID", Name = "MovieID", DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
    public int MovieID
    {
        get
        {
            return this._MovieID;
        }
        set
        {
            if ((this._MovieID != value))
            {
                this.OnPropertyChanging("MovieID");
                this._MovieID = value;
                this.OnPropertyChanged("MovieID");
            }
        }
    }

    [Column(Storage = "_Title", Name = "Title", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
    public string Title
    {
        get
        {
            return this._Title;
        }
        set
        {
            if ((this._Title != value))
            {
                this.OnPropertyChanging("Title");
                this._Title = value;
                this.OnPropertyChanged("Title");
            }
        }
    }

    [Column(Storage = "_ReleaseDate", Name = "ReleaseDate", DbType = "DateTime")]
    public global::System.Nullable<global::System.DateTime> ReleaseDate
    {
        get
        {
            return this._ReleaseDate;
        }
        set
        {
            if ((this._ReleaseDate != value))
            {
                this.OnPropertyChanging("ReleaseDate");
                this._ReleaseDate = value;
                this.OnPropertyChanged("ReleaseDate");
            }
        }
    }

    public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanging;

    public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    protected void OnPropertyChanging(string propertyName)
    {
        if ((this.PropertyChanging != null))
        {
            this.PropertyChanging(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    protected void OnPropertyChanged(string propertyName)
    {
        if ((this.PropertyChanged != null))
        {
            this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    }
}
