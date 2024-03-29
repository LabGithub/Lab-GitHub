﻿// <auto-generated />
using GreenLifeStore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GitLab.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GitLab.Models.ProductModel", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<string>("ProductDetails")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Image = "https://www.l-organic.com/wp-content/uploads/2018/05/naturya-wheatgrass-1-600x600.jpg",
                            Name = "Naturya Organic Wheatgrass Powder",
                            Price = 97f,
                            ProductDetails = "High in protein which contributes to the growth and maintenance of muscle mass Rich in iron which contributes to the normal transport of oxygen around the body and the reduction of tiredness and fatigue Natural source of vitamin A which contributes to the maintenance of normal skin and vision"
                        },
                        new
                        {
                            ProductId = 2,
                            Image = "https://www.l-organic.com/wp-content/uploads/2021/03/51BStX6N-L._AC_SS450_.jpg",
                            Name = "Clearspring Matcha Pouch",
                            Price = 90.5f,
                            ProductDetails = "Matcha is a finely milled vibrant green tea powder made from the highest quality Japanese tea leaves. Clearspring Organic Premium Matcha comes from Uji, a region high in the hills around Kyoto, renowned for producing the best Japanese teas. Only accessibly by foot, this remote area is unpolluted and rich in friendly bugs such as spiders, ladybirds, praying mantis and dragonflies to keep the pests under control (best to use organic matcha as non-organic matcha is grown using excessive amounts of agricultural fertilisers and pesticides)."
                        },
                        new
                        {
                            ProductId = 3,
                            Image = "https://www.l-organic.com/wp-content/uploads/2018/09/hampstead-peppermint.jpg",
                            Name = "Hampstead Organic Peppermint Tea",
                            Price = 17f,
                            ProductDetails = "Hampsteads organic peppermint infusion is a full flavoured, and heady. It is a unique blend of the two best loved mints, peppermint and spearmint. This gives added depth, and a fresh, tangy finish with a lingering sweet after taste. Deliciously refreshing hot or iced as a cooling summer cocktail, it is the perfect pick-me-up during the day or after a meal to cleanse the palate and aid digestion."
                        },
                        new
                        {
                            ProductId = 4,
                            Image = "https://www.l-organic.com/wp-content/uploads/2018/04/alphabites-600x600.jpg",
                            Name = "Bear Alphabites Cocoa Cereal",
                            Price = 32f,
                            ProductDetails = "Alphabites are a delicious healthy breakfast with no refined sugar or salt. Grrr. We use coconut blossom nectar, which low GI** and naturally high in calcium."
                        },
                        new
                        {
                            ProductId = 5,
                            Image = "https://www.l-organic.com/wp-content/uploads/2018/10/natures-path-crispy-rice.jpg",
                            Name = "Nature’s Path Crispy Rice Cereal",
                            Price = 30f,
                            ProductDetails = "Nature’s Path Organic Gluten Free Crispy Rice Cereal is a delicious, crunchy cereal that has been wonderfully made with organic brown rice."
                        },
                        new
                        {
                            ProductId = 6,
                            Image = "https://www.l-organic.com/wp-content/uploads/2018/03/Doves-Farm-Organic-Corn-Flakes-325g-1-600x600.jpg",
                            Name = "Doves Farm Organic Corn Flakes",
                            Price = 29f,
                            ProductDetails = "Doves Farm Organic Corn Flakes are gluten free and low in fat. Start your day with a bowl of our delicious golden flakes which are grown under the Italian sun. We’ve added malted rice syrup to create our delicious breakfast suitable for all the family."
                        },
                        new
                        {
                            ProductId = 7,
                            Image = "https://www.l-organic.com/wp-content/uploads/2019/01/amisa-fruity-oat-600x600.png",
                            Name = "Amisa Fruity Oat Muesli Cranberry & Strawberry",
                            Price = 29f,
                            ProductDetails = "Amisa Organic Gluten Free Fruity Oat Muesli is a delicious gluten free muesli, with tangy cranberries, juicy strawberries, and sunflower seeds."
                        },
                        new
                        {
                            ProductId = 8,
                            Image = "https://www.l-organic.com/wp-content/uploads/2018/02/88.jpg",
                            Name = "Biona Maple Syrup Waffles",
                            Price = 21f,
                            ProductDetails = "Organic wholegrain waffles with rich maple syrup filling. Perfect for dunking, crunching or munching on the go!"
                        },
                        new
                        {
                            ProductId = 9,
                            Image = "https://www.l-organic.com/wp-content/uploads/2019/01/biona-apple-juice-1l.jpg",
                            Name = "Biona Organic Pressed Apple Juice",
                            Price = 27f,
                            ProductDetails = "Unfiltered pure organic apple juice, with the bits. Biona organic cloudy Apple Juice is simply pressed, so more of its goodness reaches your glass."
                        },
                        new
                        {
                            ProductId = 10,
                            Image = "https://www.l-organic.com/wp-content/uploads/2020/05/Biona-Organic-Peach-Halves-in-Rice-Syrup-550g--600x600.jpg",
                            Name = "Biona Organic Peach Halves",
                            Price = 40f,
                            ProductDetails = "Naturally sweet and delicious, Peach Halves in Rice Syrup contains no added beet or cane sugar. Picked at the peak of ripeness and minimally processed,"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
