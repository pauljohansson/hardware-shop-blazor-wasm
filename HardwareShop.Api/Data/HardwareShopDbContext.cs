using HardwareShop.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace HardwareShop.Api.Data
{
    public class HardwareShopDbContext:DbContext
    {
        public HardwareShopDbContext(DbContextOptions<HardwareShopDbContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

			//Products
			//Processor Category
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 1,
				Name = "AMD Ryzen 9 5900X",
				Description = "A 12-core, 24-threads CPU by AMD",
				ImageURL = "/Images/Processor/5900x.png",
				Price = 569,
				Qty = 100,
				CategoryId = 1

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 2,
				Name = "AMD Ryzen 7 5800X3D",
				Description = "An 8-core, 16-threads CPU with the latest 3D-cache technology by AMD",
				ImageURL = "/Images/Processor/5800x3d.png",
				Price = 449,
				Qty = 100,
				CategoryId = 1

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 3,
				Name = "AMD Ryzen 5 5600X",
				Description = "A 6-core, 12-threads CPU by AMD",
				ImageURL = "/Images/Processor/5600x.png",
				Price = 309,
				Qty = 100,
				CategoryId = 1

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 4,
				Name = "Intel i7-12700K",
				Description = "A 12-core, 20-threads (8p cores, 4e cores) CPU by Intel",
				ImageURL = "/Images/Processor/i7-12700k.png",
				Price = 379,
				Qty = 100,
				CategoryId = 1

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 5,
				Name = "Intel i5-12400",
				Description = "A 6-core, 12-threads (6p cores) CPU by Intel",
				ImageURL = "/Images/Processor/i5-12400.png",
				Price = 193,
				Qty = 100,
				CategoryId = 1

			});

			//Motherboard Category
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 6,
				Name = "MSI B550 Gaming Edge WiFi",
				Description = "",
				ImageURL = "/Images/Motherboard/b550-gaming-edge-wifi.png",
				Price = 195,
				Qty = 100,
				CategoryId = 2

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 7,
				Name = "ASRock X570 Taichi",
				Description = "",
				ImageURL = "/Images/Motherboard/x570-taichi.png",
				Price = 285,
				Qty = 100,
				CategoryId = 2

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 8,
				Name = "ASUS ROG STRIX B660-F Gaming WiFi",
				Description = "",
				ImageURL = "/Images/Motherboard/b660-f-gaming-wifi.png",
				Price = 279,
				Qty = 100,
				CategoryId = 2

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 9,
				Name = "MSI MAG Z690 Tomahawk WiFi DDR4",
				Description = "",
				ImageURL = "/Images/Motherboard/z690-tomahawk-ddr4.png",
				Price = 299,
				Qty = 100,
				CategoryId = 2

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 10,
				Name = "Gigabyte Z690 Gaming X",
				Description = "",
				ImageURL = "/Images/Motherboard/z690-gaming-x.png",
				Price = 229,
				Qty = 100,
				CategoryId = 2

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 11,
				Name = "ASUS ROG Maximus Z690 Extreme",
				Description = "",
				ImageURL = "/Images/Motherboard/z690-maximus-extreme.png",
				Price = 1091,
				Qty = 50,
				CategoryId = 2
			});

			//RAM Category
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 12,
				Name = "Corsair 32GB (2x16GB) DDR4 3200MHz CL16 Vengeance LPX Black",
				Description = "",
				ImageURL = "/Images/RAM/corsair-vengeance-lpx-black.png",
				Price = 132,
				Qty = 100,
				CategoryId = 3
			});

			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 13,
				Name = "Corsair 16GB (2x8GB) DDR4 3200MHz CL16 Dominator Platinum RGB",
				Description = "",
				ImageURL = "/Images/RAM/corsair-dominator-platinum-rgb.png",
				Price = 152,
				Qty = 100,
				CategoryId = 3
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 14,
				Name = "G.Skill 32GB (2x16GB) DDR5 6000MHz CL36 Trident Z5 RGB Black",
				Description = "",
				ImageURL = "/Images/RAM/gskill-trident-rgb-black.png",
				Price = 370,
				Qty = 50,
				CategoryId = 3
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 15,
				Name = "Kingston 32GB (2x16GB) DDR5 6000MHz CL40 FURY Beast",
				Description = "",
				ImageURL = "/Images/RAM/kingston-fury-beast.png",
				Price = 309,
				Qty = 50,
				CategoryId = 3
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 16,
				Name = "Team Group 32GB 6400MHz (2x16GB) CL40 DDR5 T-Force Delta RGB White",
				Description = "",
				ImageURL = "/Images/RAM/teamgroup-tforce-delta-rgb-white.png",
				Price = 333,
				Qty = 50,
				CategoryId = 3
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 17,
				Name = "Corsair 64GB (2x32GB) DDR5 5600MHz CL40 Vengeance",
				Description = "",
				ImageURL = "/Images/RAM/corsair-vengeance-ddr5.png",
				Price = 499,
				Qty = 50,
				CategoryId = 3
			});

			//GPU Category
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 18,
				Name = "ASUS GeForce RTX 3080 10GB TUF GAMING OC",
				Description = "",
				ImageURL = "/Images/GPU/rtx3080-tuf-gaming-oc.png",
				Price = 799,
				Qty = 100,
				CategoryId = 4
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 19,
				Name = "ASUS GeForce RTX 3070 8GB ROG STRIX GAMING OC v2",
				Description = "",
				ImageURL = "/Images/GPU/rtx3070-rog-strix.png",
				Price = 685,
				Qty = 100,
				CategoryId = 4
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 20,
				Name = "EVGA GeForce RTX 3060 12GB XC GAMING",
				Description = "",
				ImageURL = "/Images/GPU/evga-rtx3060-xc-gaming.png",
				Price = 499,
				Qty = 100,
				CategoryId = 4
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 21,
				Name = "PowerColor Radeon RX 6800 XT 16GB Red Devil",
				Description = "",
				ImageURL = "/Images/GPU/rx6800xt-red-devil.png",
				Price = 769,
				Qty = 100,
				CategoryId = 4
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 22,
				Name = "MSI Radeon RX 6700 XT 12GB MECH OC",
				Description = "",
				ImageURL = "/Images/GPU/rx6700xt-mech-oc.png",
				Price = 459,
				Qty = 100,
				CategoryId = 4
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 23,
				Name = "PowerColor Radeon RX 6600 XT 8GB HellHound",
				Description = "",
				ImageURL = "/Images/GPU/rx6600xt-hellhound.png",
				Price = 359,
				Qty = 100,
				CategoryId = 4
			});

			//PSU Category
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 24,
				Name = "Seasonic Focus GX 650W",
				Description = "",
				ImageURL = "/Images/PSU/gx-650w.jpg",
				Price = 69,
				Qty = 100,
				CategoryId = 5
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 25,
				Name = "Seasonic Focus GX 750W",
				Description = "",
				ImageURL = "/Images/PSU/gx-750w.png",
				Price = 99,
				Qty = 100,
				CategoryId = 5
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 26,
				Name = "Corsair RM850 850W Black (2021)",
				Description = "",
				ImageURL = "/Images/PSU/rm850-black-2021.png",
				Price = 129,
				Qty = 100,
				CategoryId = 5
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 27,
				Name = "EVGA Supernova G3 650W",
				Description = "",
				ImageURL = "/Images/PSU/supernova-g3-650w.jpg",
				Price = 139,
				Qty = 100,
				CategoryId = 5
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 28,
				Name = "Corsair RM1000X 1000W v3",
				Description = "",
				ImageURL = "/Images/PSU/rm1000x.jpg",
				Price = 199,
				Qty = 100,
				CategoryId = 5
			});

			//Storage Category
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 29,
				Name = "Samsung 970 EVO Plus 2TB",
				Description = "",
				ImageURL = "/Images/Storage/970-evo-plus-2tb.png",
				Price = 299,
				Qty = 100,
				CategoryId = 6
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 30,
				Name = "ADATA XPG SX8200 Pro 2TB",
				Description = "",
				ImageURL = "/Images/Storage/xpg-sx8200-pro-2tb.jpg",
				Price = 299,
				Qty = 100,
				CategoryId = 6
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 31,
				Name = "Seagate Exos X16 16TB",
				Description = "",
				ImageURL = "/Images/Storage/exos-x16-16tb.jpg",
				Price = 299,
				Qty = 20,
				CategoryId = 6
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 32,
				Name = "Samsung 870 EVO SATA SSD 1TB",
				Description = "",
				ImageURL = "/Images/Storage/870-evo-1tb.png",
				Price = 149,
				Qty = 100,
				CategoryId = 6
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 33,
				Name = "Crucial MX500 1TB",
				Description = "",
				ImageURL = "/Images/Storage/mx500-1tb.jpg",
				Price = 109,
				Qty = 100,
				CategoryId = 6
			});

			//Case Category
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 34,
				Name = "Cooler Master MasterCase H500 Iron Grey",
				Description = "",
				ImageURL = "/Images/Case/h500-iron-grey.png",
				Price = 139,
				Qty = 100,
				CategoryId = 7
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 35,
				Name = "Fractal Design Define R6 Black",
				Description = "",
				ImageURL = "/Images/Case/define-r6-black.jpg",
				Price = 219,
				Qty = 100,
				CategoryId = 7
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 36,
				Name = "Lian Li LANCOOL II Mesh C RGB Black",
				Description = "",
				ImageURL = "/Images/Case/lancool-ii-meshc-black.jpg",
				Price = 119,
				Qty = 100,
				CategoryId = 7
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 37,
				Name = "Phanteks Eclipse P400A Black",
				Description = "",
				ImageURL = "/Images/Case/p400a-black.jpg",
				Price = 109,
				Qty = 100,
				CategoryId = 7
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 38,
				Name = "Fractal Design Meshify 2 ",
				Description = "",
				ImageURL = "/Images/Case/meshify-2-solid-black.png",
				Price = 219,
				Qty = 100,
				CategoryId = 7
			});

			//Cooling Category
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 39,
				Name = "Cooler Master Hyper 212 EVO V2",
				Description = "",
				ImageURL = "/Images/Cooling/hyper-212-evo-v2.jpg",
				Price = 29,
				Qty = 100,
				CategoryId = 8
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 40,
				Name = "Scythe Fuma 2",
				Description = "",
				ImageURL = "/Images/Cooling/fuma2.jpg",
				Price = 69,
				Qty = 100,
				CategoryId = 8
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 41,
				Name = "Noctua NH-D15 chromax Black",
				Description = "",
				ImageURL = "/Images/Cooling/nh-d15-chromax-black.jpg",
				Price = 119,
				Qty = 100,
				CategoryId = 8
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 42,
				Name = "Arctic Liquid Freezer II 360",
				Description = "",
				ImageURL = "/Images/Cooling/liquid-freezer-ii-360.jpg",
				Price = 129,
				Qty = 100,
				CategoryId = 8
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 43,
				Name = "Corsair iCUE H150i ELITE CAPELLIX",
				Description = "",
				ImageURL = "/Images/Cooling/icue-h150i-elite-capellix.png",
				Price = 199,
				Qty = 100,
				CategoryId = 8
			});

			//Add users
			modelBuilder.Entity<User>().HasData(new User
			{
				Id = 1,
				UserName = "Bob"

			});
			modelBuilder.Entity<User>().HasData(new User
			{
				Id = 2,
				UserName = "Sarah"

			});

			//Create Shopping Cart for Users
			modelBuilder.Entity<Cart>().HasData(new Cart
			{
				Id = 1,
				UserId = 1

			});
			modelBuilder.Entity<Cart>().HasData(new Cart
			{
				Id = 2,
				UserId = 2

			});

			//Add Product Categories
			modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
			{
				Id = 1,
				Name = "Processor"
			});
			modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
			{
				Id = 2,
				Name = "Motherboard"
			});
			modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
			{
				Id = 3,
				Name = "RAM"
			});
			modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
			{
				Id = 4,
				Name = "GPU"
			});
			modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
			{
				Id = 5,
				Name = "PSU"
			});
			modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
			{
				Id = 6,
				Name = "Storage"
			});
			modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
			{
				Id = 7,
				Name = "Case"
			});
			modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
			{
				Id = 8,
				Name = "Cooling"
			});
		}

        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
