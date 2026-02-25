using System.Dynamic;

public class Supplier
{
    public Int32 SupplierID {set; get;}
    public String SupplierName {set; get;}
    public String ContactName {set; get;}
    public String Address {set; get;}
    public String City {set; get;}
    public String PostalCode {set; get;}
    public String Country {set; get;}
    public String Phone {set; get;}
}

public class Product
{
    public Int32 ProductID {set; get;}
    public String ProductName {set; get;}
    public Int32 SupplierID {set; get;}
    public Int32 CategoryID {set; get;}
    public String Unit {set; get;}
    public Double Price {set; get;}
}

public class ProductSupplier
{
    public Int32 SupplierID {set; get;}
    public String SupplierName {set; get;}
    public String ContactName {set; get;}
    public String Address {set; get;}
    public String City {set; get;}
    public String PostalCode {set; get;}
    public String Country {set; get;}
    public String Phone {set; get;}

    public Int32 ProductID {set; get;}
    public String ProductName {set; get;}
    public Int32 CategoryID {set; get;}
    public String Unit {set; get;}
    public Double Price {set; get;}
}

public class Customer
{
    public Int32 CustomerID {set; get;}
    public String CustomerName {set; get;}
    public String ContactName {set; get;}
    public String Address {set; get;}
    public String City {set; get;}
    public String PostalCode {set; get;}
    public String Country {set; get;}
}

public class Category
{
    public Int32 CategoryID{set; get;}
    public String CategoryName{set; get;}
    public String Description{set; get;}
}

public class ProductCategory
{
    public Int32 CategoryID{set; get;}
    public String CategoryName{set; get;}
    public String Description{set; get;}

    public Int32 ProductID {set; get;}
    public String ProductName {set; get;}
    public Int32 SupplierID {set; get;}
    public String Unit {set; get;}
    public Double Price {set; get;}
}