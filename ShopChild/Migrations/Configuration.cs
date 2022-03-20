namespace ShopChild.Migrations
{
    using ShopChild.Models;
    using ShopChild.Util;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ShopChild.Data.MyDBConfig>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ShopChild.Data.MyDBConfig context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            var categories = new List<Category> {
                new Category {Id = "A001", Name = "Áo"},
                new Category {Id = "A002", Name = "Quần"}
            };

            var products = new List<Product>
            {
                new Product {Id = GenarateUUID.Create(), Name = "Áo vải bé gái tay dài", Price = 94500, Thumbnail = "https://res.cloudinary.com/nguyenhs/image/upload/v1647710309/Sem3/Asp.Net/body-dai-tay-be-_gai-bibo_s-trang_-phoi-ao-khoac_dpxafm.jpg", CategoryId = "A001"},
                new Product {Id = GenarateUUID.Create(), Name = "Áo bé gái dài Animo G1221001 (6M-3Y,Hồng)", Price = 100000, Thumbnail = "https://res.cloudinary.com/nguyenhs/image/upload/v1647710356/Sem3/Asp.Net/body-vay-be-gai-bibo-s-hong-tutu-ghi_hrczb9.webp", CategoryId = "A001"},
                new Product {Id = GenarateUUID.Create(), Name = "Bộ sơ sinh dài dêt jacquard Animo I1121048 (0-12M,Hồng nhạt)", Price = 95000, Thumbnail = "https://res.cloudinary.com/nguyenhs/image/upload/v1647710255/Sem3/Asp.Net/set-ao-ct-mix-body-xo-bt-bibos-in-gau-trang-ghi-131253-1_rfca2l.webp", CategoryId = "A001"},
                new Product {Id = GenarateUUID.Create(), Name = "Bộ quần áo len bé gái gấu trúc và thỏ hồng", Price = 289000, Thumbnail = "https://res.cloudinary.com/nguyenhs/image/upload/v1647709872/Sem3/Asp.Net/bo-quan-ao-len-be-gai-hinh-gau-truc-va-tho-1_wbvjxx.webp", CategoryId = "A001"},
                new Product {Id = GenarateUUID.Create(), Name = "Áo khoác bé trai Bibos khủng long ghi", Price = 299000, Thumbnail = "https://res.cloudinary.com/nguyenhs/image/upload/v1647710406/Sem3/Asp.Net/ao-khoac-be-trai-bibos-khung-long-ghi_1_p9q9zt.webp", CategoryId = "A001"},
                new Product {Id = GenarateUUID.Create(), Name = "Quần dài bé trai Bibo's màu ghi đậm", Price = 149000, Thumbnail = "https://res.cloudinary.com/nguyenhs/image/upload/v1647710499/Sem3/Asp.Net/quan-dai-be-trai-bibo-s-mau-ghi-dam_zoumtb.webp", CategoryId = "A002"},
                new Product {Id = GenarateUUID.Create(), Name = "Áo gile len bé gái hình gấu thắt nơ", Price = 149000, Thumbnail = "https://res.cloudinary.com/nguyenhs/image/upload/v1647710551/Sem3/Asp.Net/130578c-16-10-2021-23_ymev4i.jpg", CategoryId = "A001"},
                new Product {Id = GenarateUUID.Create(), Name = "Áo khoác bé trai Bibo's bông xốp đám mây ghi", Price = 319000, Thumbnail = "https://res.cloudinary.com/nguyenhs/image/upload/v1647710610/Sem3/Asp.Net/ao-khoac-be-trai-_bibos-bong-xop-_dam-may-ghi_uq7kqu.webp", CategoryId = "A001"},
                new Product {Id = GenarateUUID.Create(), Name = "Áo khoác phao khủng long", Price = 279000, Thumbnail = "https://res.cloudinary.com/nguyenhs/image/upload/v1647710676/Sem3/Asp.Net/ao-khoac-phao-khung-long-nang-luong_1_wwg3nt.jpg", CategoryId = "A001"},
                new Product {Id = GenarateUUID.Create(), Name = "Áo gile len cài lệch Momma Smile", Price = 159000, Thumbnail = "https://res.cloudinary.com/nguyenhs/image/upload/v1647710746/Sem3/Asp.Net/130357c-16-10-2021-18_nbdcfw.jpg", CategoryId = "A001"},
                new Product {Id = GenarateUUID.Create(), Name = "Quần dài bé trai Chong Chóng vải xô", Price = 119000, Thumbnail = "https://res.cloudinary.com/nguyenhs/image/upload/v1647710746/Sem3/Asp.Net/130357c-16-10-2021-18_nbdcfw.jpg", CategoryId = "A002"},
                new Product {Id = GenarateUUID.Create(), Name = "Áo len cài giữa Momma kẻ ngang", Price = 169000, Thumbnail = "https://res.cloudinary.com/nguyenhs/image/upload/v1647710852/Sem3/Asp.Net/130695c-16-10-2021-27_jitrxs.jpg", CategoryId = "A001"},

            };
            categories.ForEach(e => context.Category.Add(e));
            products.ForEach(e => context.Product.Add(e));
        }
    }
}
