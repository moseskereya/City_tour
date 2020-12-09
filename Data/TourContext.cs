using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tour.Models;

namespace Tour.Data
{
    public class TourContext : DbContext
    {
        public TourContext(DbContextOptions<TourContext> options) : base(options)
        {
        }
        public DbSet<City> Cities { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Upcoming> Upcomings { get; set; }

       protected override void OnModelCreating(ModelBuilder modelBuilder)
       {
            modelBuilder.Entity<City>().HasData(
                new City { 
                    Id = 1,
                    Name = "Milano",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus id feugiat quam. Etiam eros leo, faucibus iaculis tempor ac, faucibus ut velit. Sed nunc elit, efficitur tristique tristique eu, vestibulum et purus. Nullam at dolor ac elit elementum interdum. Donec eget enim vel orci convallis tincidunt at eget odio. Aliquam congue vel tortor vitae gravida. Vestibulum vulputate nisl vel semper posuere. Nulla elementum scelerisque odio, eu elementum nisi commodo sed. Donec aliquet venenatis faucibus. Donec lacinia ante dui, luctus viverra orci volutpat porttitor. Nullam non nunc elit. Proin gravida vulputate massa, eget posuere mi. Integer et fermentum velit. Quisque laoreet dignissim arcu, non malesuada odio dictum vel. Nam mollis ultricies massa eget blandit",
                    Image = "https://images.pexels.com/photos/466685/pexels-photo-466685.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                    EventDate = DateTime.Parse("12-04-2020"),
                    LocationId = 1,
                    Ratings = null
                },
                new City
                {
                    Id = 2,
                    Name = "Beijing",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus id feugiat quam. Etiam eros leo, faucibus iaculis tempor ac, faucibus ut velit. Sed nunc elit, efficitur tristique tristique eu, vestibulum et purus. Nullam at dolor ac elit elementum interdum. Donec eget enim vel orci convallis tincidunt at eget odio. Aliquam congue vel tortor vitae gravida. Vestibulum vulputate nisl vel semper posuere. Nulla elementum scelerisque odio, eu elementum nisi commodo sed. Donec aliquet venenatis faucibus. Donec lacinia ante dui, luctus viverra orci volutpat porttitor. Nullam non nunc elit. Proin gravida vulputate massa, eget posuere mi. Integer et fermentum velit. Quisque laoreet dignissim arcu, non malesuada odio dictum vel. Nam mollis ultricies massa eget blandit",
                    Image = "https://images.pexels.com/photos/466685/pexels-photo-466685.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                    EventDate = DateTime.Parse("06-01-2020"),
                    LocationId = 1,
                    Ratings = null

                },
                new City
                {
                    Id = 3,
                    Name = "Miami",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus id feugiat quam. Etiam eros leo, faucibus iaculis tempor ac, faucibus ut velit. Sed nunc elit, efficitur tristique tristique eu, vestibulum et purus. Nullam at dolor ac elit elementum interdum. Donec eget enim vel orci convallis tincidunt at eget odio. Aliquam congue vel tortor vitae gravida. Vestibulum vulputate nisl vel semper posuere. Nulla elementum scelerisque odio, eu elementum nisi commodo sed. Donec aliquet venenatis faucibus. Donec lacinia ante dui, luctus viverra orci volutpat porttitor. Nullam non nunc elit. Proin gravida vulputate massa, eget posuere mi. Integer et fermentum velit. Quisque laoreet dignissim arcu, non malesuada odio dictum vel. Nam mollis ultricies massa eget blandit",
                    Image = "https://images.pexels.com/photos/417192/pexels-photo-417192.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                    EventDate = DateTime.Parse("06-01-2020"),
                    LocationId = 1,
                    Ratings = null

                },
                new City
                {
                    Id = 4,
                    Name = "New Delh",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus id feugiat quam. Etiam eros leo, faucibus iaculis tempor ac, faucibus ut velit. Sed nunc elit, efficitur tristique tristique eu, vestibulum et purus. Nullam at dolor ac elit elementum interdum. Donec eget enim vel orci convallis tincidunt at eget odio. Aliquam congue vel tortor vitae gravida. Vestibulum vulputate nisl vel semper posuere. Nulla elementum scelerisque odio, eu elementum nisi commodo sed. Donec aliquet venenatis faucibus. Donec lacinia ante dui, luctus viverra orci volutpat porttitor. Nullam non nunc elit. Proin gravida vulputate massa, eget posuere mi. Integer et fermentum velit. Quisque laoreet dignissim arcu, non malesuada odio dictum vel. Nam mollis ultricies massa eget blandit",
                    Image = "https://images.pexels.com/photos/1525612/pexels-photo-1525612.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                    EventDate = DateTime.Parse("07-05-2021"),
                    LocationId = 1,
                    Ratings = null

                },
                new City
                {
                    Id = 5,
                    Name = "Mexico",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus id feugiat quam. Etiam eros leo, faucibus iaculis tempor ac, faucibus ut velit. Sed nunc elit, efficitur tristique tristique eu, vestibulum et purus. Nullam at dolor ac elit elementum interdum. Donec eget enim vel orci convallis tincidunt at eget odio. Aliquam congue vel tortor vitae gravida. Vestibulum vulputate nisl vel semper posuere. Nulla elementum scelerisque odio, eu elementum nisi commodo sed. Donec aliquet venenatis faucibus. Donec lacinia ante dui, luctus viverra orci volutpat porttitor. Nullam non nunc elit. Proin gravida vulputate massa, eget posuere mi. Integer et fermentum velit. Quisque laoreet dignissim arcu, non malesuada odio dictum vel. Nam mollis ultricies massa eget blandit",
                    Image = "https://images.pexels.com/photos/936722/pexels-photo-936722.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                    EventDate = DateTime.Parse("09-02-2021"),
                    LocationId = 1,
                    Ratings = null

                },
                new City
                {
                    Id = 6,
                    Name = "London",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus id feugiat quam. Etiam eros leo, faucibus iaculis tempor ac, faucibus ut velit. Sed nunc elit, efficitur tristique tristique eu, vestibulum et purus. Nullam at dolor ac elit elementum interdum. Donec eget enim vel orci convallis tincidunt at eget odio. Aliquam congue vel tortor vitae gravida. Vestibulum vulputate nisl vel semper posuere. Nulla elementum scelerisque odio, eu elementum nisi commodo sed. Donec aliquet venenatis faucibus. Donec lacinia ante dui, luctus viverra orci volutpat porttitor. Nullam non nunc elit. Proin gravida vulputate massa, eget posuere mi. Integer et fermentum velit. Quisque laoreet dignissim arcu, non malesuada odio dictum vel. Nam mollis ultricies massa eget blandit",
                    Image = "https://images.pexels.com/photos/1525612/pexels-photo-1525612.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                    EventDate = DateTime.Parse("10-02-2020"),
                    LocationId = 2,
                    Ratings = null

                },

                   new City
                   {
                    Id = 7,
                    Name = "Copenhagen",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus id feugiat quam. Etiam eros leo, faucibus iaculis tempor ac, faucibus ut velit. Sed nunc elit, efficitur tristique tristique eu, vestibulum et purus. Nullam at dolor ac elit elementum interdum. Donec eget enim vel orci convallis tincidunt at eget odio. Aliquam congue vel tortor vitae gravida. Vestibulum vulputate nisl vel semper posuere. Nulla elementum scelerisque odio, eu elementum nisi commodo sed. Donec aliquet venenatis faucibus. Donec lacinia ante dui, luctus viverra orci volutpat porttitor. Nullam non nunc elit. Proin gravida vulputate massa, eget posuere mi. Integer et fermentum velit. Quisque laoreet dignissim arcu, non malesuada odio dictum vel. Nam mollis ultricies massa eget blandit",
                    Image = "https://images.pexels.com/photos/3065260/pexels-photo-3065260.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                    EventDate = DateTime.Parse("17-01-2021"),
                    LocationId = 2,
                    Ratings = null

                   },

                new City
                {
                    Id = 8,
                    Name = "Amsterdam",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus id feugiat quam. Etiam eros leo, faucibus iaculis tempor ac, faucibus ut velit. Sed nunc elit, efficitur tristique tristique eu, vestibulum et purus. Nullam at dolor ac elit elementum interdum. Donec eget enim vel orci convallis tincidunt at eget odio. Aliquam congue vel tortor vitae gravida. Vestibulum vulputate nisl vel semper posuere. Nulla elementum scelerisque odio, eu elementum nisi commodo sed. Donec aliquet venenatis faucibus. Donec lacinia ante dui, luctus viverra orci volutpat porttitor. Nullam non nunc elit. Proin gravida vulputate massa, eget posuere mi. Integer et fermentum velit. Quisque laoreet dignissim arcu, non malesuada odio dictum vel. Nam mollis ultricies massa eget blandit",
                    Image = "https://images.pexels.com/photos/1036657/pexels-photo-1036657.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                    EventDate = DateTime.Parse("14-09-2020"),
                    LocationId = 2,
                    Ratings = null

                },
                new City
                {
                    Id = 9,
                    Name = "Ny City",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus id feugiat quam. Etiam eros leo, faucibus iaculis tempor ac, faucibus ut velit. Sed nunc elit, efficitur tristique tristique eu, vestibulum et purus. Nullam at dolor ac elit elementum interdum. Donec eget enim vel orci convallis tincidunt at eget odio. Aliquam congue vel tortor vitae gravida. Vestibulum vulputate nisl vel semper posuere. Nulla elementum scelerisque odio, eu elementum nisi commodo sed. Donec aliquet venenatis faucibus. Donec lacinia ante dui, luctus viverra orci volutpat porttitor. Nullam non nunc elit. Proin gravida vulputate massa, eget posuere mi. Integer et fermentum velit. Quisque laoreet dignissim arcu, non malesuada odio dictum vel. Nam mollis ultricies massa eget blandit",
                    Image = "https://images.pexels.com/photos/1334605/pexels-photo-1334605.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=300",
                    EventDate = DateTime.Parse("01-02-2020"),
                    LocationId = 2,
                    Ratings = null

                },
                new City
                {
                    Id = 10,
                    Name = "Madrid",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus id feugiat quam. Etiam eros leo, faucibus iaculis tempor ac, faucibus ut velit. Sed nunc elit, efficitur tristique tristique eu, vestibulum et purus. Nullam at dolor ac elit elementum interdum. Donec eget enim vel orci convallis tincidunt at eget odio. Aliquam congue vel tortor vitae gravida. Vestibulum vulputate nisl vel semper posuere. Nulla elementum scelerisque odio, eu elementum nisi commodo sed. Donec aliquet venenatis faucibus. Donec lacinia ante dui, luctus viverra orci volutpat porttitor. Nullam non nunc elit. Proin gravida vulputate massa, eget posuere mi. Integer et fermentum velit. Quisque laoreet dignissim arcu, non malesuada odio dictum vel. Nam mollis ultricies massa eget blandit",
                    Image = "https://images.pexels.com/photos/1697358/pexels-photo-1697358.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                    EventDate = DateTime.Parse("13-05-2020"),
                    LocationId = 2,
                    Ratings = null

                },

                new City
                {
                    Id = 11,
                    Name = "Barcelona",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus id feugiat quam. Etiam eros leo, faucibus iaculis tempor ac, faucibus ut velit. Sed nunc elit, efficitur tristique tristique eu, vestibulum et purus. Nullam at dolor ac elit elementum interdum. Donec eget enim vel orci convallis tincidunt at eget odio. Aliquam congue vel tortor vitae gravida. Vestibulum vulputate nisl vel semper posuere. Nulla elementum scelerisque odio, eu elementum nisi commodo sed. Donec aliquet venenatis faucibus. Donec lacinia ante dui, luctus viverra orci volutpat porttitor. Nullam non nunc elit. Proin gravida vulputate massa, eget posuere mi. Integer et fermentum velit. Quisque laoreet dignissim arcu, non malesuada odio dictum vel. Nam mollis ultricies massa eget blandit",
                    Image = "https://images.pexels.com/photos/58603/pexels-photo-58603.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                    EventDate = DateTime.Parse("13-02-2022"),
                    LocationId = 2,
                    Ratings = null

                },
                new City
                {
                    Id = 12,
                    Name = "Chicago",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus id feugiat quam. Etiam eros leo, faucibus iaculis tempor ac, faucibus ut velit. Sed nunc elit, efficitur tristique tristique eu, vestibulum et purus. Nullam at dolor ac elit elementum interdum. Donec eget enim vel orci convallis tincidunt at eget odio. Aliquam congue vel tortor vitae gravida. Vestibulum vulputate nisl vel semper posuere. Nulla elementum scelerisque odio, eu elementum nisi commodo sed. Donec aliquet venenatis faucibus. Donec lacinia ante dui, luctus viverra orci volutpat porttitor. Nullam non nunc elit. Proin gravida vulputate massa, eget posuere mi. Integer et fermentum velit. Quisque laoreet dignissim arcu, non malesuada odio dictum vel. Nam mollis ultricies massa eget blandit",
                    Image = "https://images.pexels.com/photos/2116721/pexels-photo-2116721.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                    EventDate = DateTime.Parse("15-08-2021"),
                    LocationId = 2,
                    Ratings = null

                },
                new City
                {
                    Id = 13,
                    Name = "Seoul",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus id feugiat quam. Etiam eros leo, faucibus iaculis tempor ac, faucibus ut velit. Sed nunc elit, efficitur tristique tristique eu, vestibulum et purus. Nullam at dolor ac elit elementum interdum. Donec eget enim vel orci convallis tincidunt at eget odio. Aliquam congue vel tortor vitae gravida. Vestibulum vulputate nisl vel semper posuere. Nulla elementum scelerisque odio, eu elementum nisi commodo sed. Donec aliquet venenatis faucibus. Donec lacinia ante dui, luctus viverra orci volutpat porttitor. Nullam non nunc elit. Proin gravida vulputate massa, eget posuere mi. Integer et fermentum velit. Quisque laoreet dignissim arcu, non malesuada odio dictum vel. Nam mollis ultricies massa eget blandit",
                    Image = "https://images.pexels.com/photos/1738997/pexels-photo-1738997.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                    EventDate = DateTime.Parse("07-08-2021"),
                    LocationId = 2,
                    Ratings = null

                },
                new City
                {
                    Id = 14,
                    Name = "Berlin",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus id feugiat quam. Etiam eros leo, faucibus iaculis tempor ac, faucibus ut velit. Sed nunc elit, efficitur tristique tristique eu, vestibulum et purus. Nullam at dolor ac elit elementum interdum. Donec eget enim vel orci convallis tincidunt at eget odio. Aliquam congue vel tortor vitae gravida. Vestibulum vulputate nisl vel semper posuere. Nulla elementum scelerisque odio, eu elementum nisi commodo sed. Donec aliquet venenatis faucibus. Donec lacinia ante dui, luctus viverra orci volutpat porttitor. Nullam non nunc elit. Proin gravida vulputate massa, eget posuere mi. Integer et fermentum velit. Quisque laoreet dignissim arcu, non malesuada odio dictum vel. Nam mollis ultricies massa eget blandit",
                    Image = "https://images.pexels.com/photos/374811/pexels-photo-374811.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                    EventDate = DateTime.Parse("13-08-2021"),
                    LocationId = 2,
                    Ratings = null

                },
                new City
                {
                    Id = 15,
                    Name = "Zurich",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus id feugiat quam. Etiam eros leo, faucibus iaculis tempor ac, faucibus ut velit. Sed nunc elit, efficitur tristique tristique eu, vestibulum et purus. Nullam at dolor ac elit elementum interdum. Donec eget enim vel orci convallis tincidunt at eget odio. Aliquam congue vel tortor vitae gravida. Vestibulum vulputate nisl vel semper posuere. Nulla elementum scelerisque odio, eu elementum nisi commodo sed. Donec aliquet venenatis faucibus. Donec lacinia ante dui, luctus viverra orci volutpat porttitor. Nullam non nunc elit. Proin gravida vulputate massa, eget posuere mi. Integer et fermentum velit. Quisque laoreet dignissim arcu, non malesuada odio dictum vel. Nam mollis ultricies massa eget blandit",
                    Image = "https://images.pexels.com/photos/302769/pexels-photo-302769.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                    EventDate = DateTime.Parse("10-01-2022"),
                    LocationId = 2,
                    Ratings = null

                },
                new City
                {
                    Id = 16,
                    Name = "Toronto",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus id feugiat quam. Etiam eros leo, faucibus iaculis tempor ac, faucibus ut velit. Sed nunc elit, efficitur tristique tristique eu, vestibulum et purus. Nullam at dolor ac elit elementum interdum. Donec eget enim vel orci convallis tincidunt at eget odio. Aliquam congue vel tortor vitae gravida. Vestibulum vulputate nisl vel semper posuere. Nulla elementum scelerisque odio, eu elementum nisi commodo sed. Donec aliquet venenatis faucibus. Donec lacinia ante dui, luctus viverra orci volutpat porttitor. Nullam non nunc elit. Proin gravida vulputate massa, eget posuere mi. Integer et fermentum velit. Quisque laoreet dignissim arcu, non malesuada odio dictum vel. Nam mollis ultricies massa eget blandit",
                    Image = "https://images.pexels.com/photos/416998/pexels-photo-416998.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                    EventDate = DateTime.Parse("07-01-2021"),
                    LocationId = 2,
                    Ratings = null

                },
                new City
                {
                    Id = 17,
                    Name = "Sydney",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus id feugiat quam. Etiam eros leo, faucibus iaculis tempor ac, faucibus ut velit. Sed nunc elit, efficitur tristique tristique eu, vestibulum et purus. Nullam at dolor ac elit elementum interdum. Donec eget enim vel orci convallis tincidunt at eget odio. Aliquam congue vel tortor vitae gravida. Vestibulum vulputate nisl vel semper posuere. Nulla elementum scelerisque odio, eu elementum nisi commodo sed. Donec aliquet venenatis faucibus. Donec lacinia ante dui, luctus viverra orci volutpat porttitor. Nullam non nunc elit. Proin gravida vulputate massa, eget posuere mi. Integer et fermentum velit. Quisque laoreet dignissim arcu, non malesuada odio dictum vel. Nam mollis ultricies massa eget blandit",
                    Image = "https://images.pexels.com/photos/1485894/pexels-photo-1485894.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                    EventDate = DateTime.Parse("05-01-2021"),
                    LocationId = 1,
                    Ratings = null

                },
                new City
                {
                    Id = 18,
                    Name = "Osaka",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus id feugiat quam. Etiam eros leo, faucibus iaculis tempor ac, faucibus ut velit. Sed nunc elit, efficitur tristique tristique eu, vestibulum et purus. Nullam at dolor ac elit elementum interdum. Donec eget enim vel orci convallis tincidunt at eget odio. Aliquam congue vel tortor vitae gravida. Vestibulum vulputate nisl vel semper posuere. Nulla elementum scelerisque odio, eu elementum nisi commodo sed. Donec aliquet venenatis faucibus. Donec lacinia ante dui, luctus viverra orci volutpat porttitor. Nullam non nunc elit. Proin gravida vulputate massa, eget posuere mi. Integer et fermentum velit. Quisque laoreet dignissim arcu, non malesuada odio dictum vel. Nam mollis ultricies massa eget blandit",
                    Image = "https://images.pexels.com/photos/3065260/pexels-photo-3065260.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                    EventDate = DateTime.Parse("07-06-2021"),
                    LocationId = 2,
                    Ratings = null

                },
                new City
                {
                    Id = 19,
                    Name = "Tokyo",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus id feugiat quam. Etiam eros leo, faucibus iaculis tempor ac, faucibus ut velit. Sed nunc elit, efficitur tristique tristique eu, vestibulum et purus. Nullam at dolor ac elit elementum interdum. Donec eget enim vel orci convallis tincidunt at eget odio. Aliquam congue vel tortor vitae gravida. Vestibulum vulputate nisl vel semper posuere. Nulla elementum scelerisque odio, eu elementum nisi commodo sed. Donec aliquet venenatis faucibus. Donec lacinia ante dui, luctus viverra orci volutpat porttitor. Nullam non nunc elit. Proin gravida vulputate massa, eget posuere mi. Integer et fermentum velit. Quisque laoreet dignissim arcu, non malesuada odio dictum vel. Nam mollis ultricies massa eget blandit",
                    Image = "https://images.pexels.com/photos/416998/pexels-photo-416998.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                    EventDate = DateTime.Parse("25-06-2021"),
                    LocationId = 3,
                    Ratings = null

                },
                new City
                {
                    Id = 20,
                    Name = "WA,DC",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus id feugiat quam. Etiam eros leo, faucibus iaculis tempor ac, faucibus ut velit. Sed nunc elit, efficitur tristique tristique eu, vestibulum et purus. Nullam at dolor ac elit elementum interdum. Donec eget enim vel orci convallis tincidunt at eget odio. Aliquam congue vel tortor vitae gravida. Vestibulum vulputate nisl vel semper posuere. Nulla elementum scelerisque odio, eu elementum nisi commodo sed. Donec aliquet venenatis faucibus. Donec lacinia ante dui, luctus viverra orci volutpat porttitor. Nullam non nunc elit. Proin gravida vulputate massa, eget posuere mi. Integer et fermentum velit. Quisque laoreet dignissim arcu, non malesuada odio dictum vel. Nam mollis ultricies massa eget blandit",
                    Image = "https://images.pexels.com/photos/1105766/pexels-photo-1105766.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                    EventDate = DateTime.Parse("02-11-2021"),
                    LocationId = 2,
                    Ratings = null

                },
                 new City
                 {
                     Id = 21,
                     Name = "Bogota",
                     Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus id feugiat quam. Etiam eros leo, faucibus iaculis tempor ac, faucibus ut velit. Sed nunc elit, efficitur tristique tristique eu, vestibulum et purus. Nullam at dolor ac elit elementum interdum. Donec eget enim vel orci convallis tincidunt at eget odio. Aliquam congue vel tortor vitae gravida. Vestibulum vulputate nisl vel semper posuere. Nulla elementum scelerisque odio, eu elementum nisi commodo sed. Donec aliquet venenatis faucibus. Donec lacinia ante dui, luctus viverra orci volutpat porttitor. Nullam non nunc elit. Proin gravida vulputate massa, eget posuere mi. Integer et fermentum velit. Quisque laoreet dignissim arcu, non malesuada odio dictum vel. Nam mollis ultricies massa eget blandit",
                     Image = "https://images.pexels.com/photos/681335/pexels-photo-681335.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                     EventDate = DateTime.Parse("01-09-2021"),
                     LocationId = 2,
                     Ratings = null

                 });

                modelBuilder.Entity<Upcoming>().HasData(
                new City
                {
                    Id = 1,
                    Name = "Osaka",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus id feugiat quam. Etiam eros leo, faucibus iaculis tempor ac, faucibus ut velit. Sed nunc elit, efficitur tristique tristique eu, vestibulum et purus. Nullam at dolor ac elit elementum interdum. Donec eget enim vel orci convallis tincidunt at eget odio. Aliquam congue vel tortor vitae gravida. Vestibulum vulputate nisl vel semper posuere. Nulla elementum scelerisque odio, eu elementum nisi commodo sed. Donec aliquet venenatis faucibus. Donec lacinia ante dui, luctus viverra orci volutpat porttitor. Nullam non nunc elit. Proin gravida vulputate massa, eget posuere mi. Integer et fermentum velit. Quisque laoreet dignissim arcu, non malesuada odio dictum vel. Nam mollis ultricies massa eget blandit",
                    Image = "https://images.pexels.com/photos/3065260/pexels-photo-3065260.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                    EventDate = DateTime.Parse("23-11-2020"),
                    LocationId = 2,
                    Ratings = null,
                },
                new City
                {
                    Id = 2,
                    Name = "Tokyo",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus id feugiat quam. Etiam eros leo, faucibus iaculis tempor ac, faucibus ut velit. Sed nunc elit, efficitur tristique tristique eu, vestibulum et purus. Nullam at dolor ac elit elementum interdum. Donec eget enim vel orci convallis tincidunt at eget odio. Aliquam congue vel tortor vitae gravida. Vestibulum vulputate nisl vel semper posuere. Nulla elementum scelerisque odio, eu elementum nisi commodo sed. Donec aliquet venenatis faucibus. Donec lacinia ante dui, luctus viverra orci volutpat porttitor. Nullam non nunc elit. Proin gravida vulputate massa, eget posuere mi. Integer et fermentum velit. Quisque laoreet dignissim arcu, non malesuada odio dictum vel. Nam mollis ultricies massa eget blandit",
                    Image = "https://images.pexels.com/photos/416998/pexels-photo-416998.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                    EventDate = DateTime.Parse("25-11-2020"),
                    LocationId = 3,
                    Ratings = null

                },
                new City
                {
                    Id = 3,
                    Name = "WA,DC",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus id feugiat quam. Etiam eros leo, faucibus iaculis tempor ac, faucibus ut velit. Sed nunc elit, efficitur tristique tristique eu, vestibulum et purus. Nullam at dolor ac elit elementum interdum. Donec eget enim vel orci convallis tincidunt at eget odio. Aliquam congue vel tortor vitae gravida. Vestibulum vulputate nisl vel semper posuere. Nulla elementum scelerisque odio, eu elementum nisi commodo sed. Donec aliquet venenatis faucibus. Donec lacinia ante dui, luctus viverra orci volutpat porttitor. Nullam non nunc elit. Proin gravida vulputate massa, eget posuere mi. Integer et fermentum velit. Quisque laoreet dignissim arcu, non malesuada odio dictum vel. Nam mollis ultricies massa eget blandit",
                    Image = "https://images.pexels.com/photos/1105766/pexels-photo-1105766.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                    EventDate = DateTime.Parse("30-11-2020"),
                    LocationId = 2,
                    Ratings = null

                });

                 modelBuilder.Entity<Location>().HasData(
                new Location
                {
                    LocationId = 1,
                    Place = "City Parks,  Historical Places and Technology Invantions Areas",
                    Continent = "Africa and Asia"
                },
                new Location
                {
                    LocationId = 2,
                    Place = "City Parks,  Historical Places and Technology Invantions Areas",
                    Continent = "America and Asia Africa"
                },
                new Location
                {
                    LocationId = 3,
                    Place = "City Parks,  Historical Places and Technology Invantions Areas",
                    Continent = "America, Africa and Asia"
                },
                new Location
                {
                    LocationId = 4,
                    Place = "City Parks,  Historical Places and Technology Invantions Areas",
                    Continent = "America and Asia"
                }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
