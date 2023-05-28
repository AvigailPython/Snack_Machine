﻿using DP;
using DP.Products;
using MyMachine.Products;
using MyMachine.Stock.Stock;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMachine.AllStock;

public class Stock
{
    //public void InitProduct<T>(eProduct P, int amount) where T : Product, new()
    //{
    //    for (int i = 0; i < amount; i++)
    //    {
    //        AllProducts[P].Add(new T());
    //    }
    //}
    //public void InitProduct<T>(eRawMaterials P, int amount) where T : Product, new()
    //{
    //    for (int i = 0; i < amount; i++)
    //    {
    //        AllRawMaterials[P].Add(new T());
    //    }
    //}
    public Dictionary<eProduct, double> Prices { get; set; }
    public Dictionary<eProduct, ProductStock<Product>> AllProducts { get; set; }
    public Dictionary<eRawMaterials, List<Product>> AllRawMaterials { get; set; }
    public Stock()
    {
        Prices = new Dictionary<eProduct, double>
        {
            { eProduct.Bamba, Bamba.Price },
            { eProduct.Bisli, Bisli.Price },
            { eProduct.Doritos, Doritos.Price },
            { eProduct.Cola, Cola.Price },
            { eProduct.Juice, Juice.Price },
            { eProduct.Water, Water.Price },
            { eProduct.Coffee, Coffee.Price },
            { eProduct.Coco, Coco.Price },
            { eProduct.Cappucino, Cappucino.Price },
            { eProduct.BlackCoffee, BlackCoffee.Price }

        };
        //AllProducts = new Dictionary<eProduct, ProductStock<Product>> {
        //    { eProduct.Bamba, new BambaStock(3)},
        //    { eProduct.Bisli, new BisliStock()},
        //    { eProduct.Doritos,new DoritosStock() },
        //    { eProduct.Cola, new ColaStock() },
        //    { eProduct.Juice, new JuiceStock()},
        //    { eProduct.Water,new WaterStock()},
        //};
        AllProducts = new Dictionary<eProduct, ProductStock<Product>>();
        AllProducts.Add(eProduct.Bamba, new ProductStock<Product>(3));
        AllRawMaterials = new Dictionary<eRawMaterials, List<Product>> {
            { eRawMaterials.BlckCoffeePowder, new List<Product>()},
            { eRawMaterials.CocoPowder, new List<Product>()},
            { eRawMaterials.CoffeePowder,new List<Product>() },
            { eRawMaterials.Sugar, new List<Product>() },
            { eRawMaterials.Milk, new List<Product>()},
        };
        
    }
}
