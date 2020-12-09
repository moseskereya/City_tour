using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tour.Migrations
{
    public partial class AddingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationId", "Continent", "Place" },
                values: new object[,]
                {
                    { 1, "Africa and Asia", "City Parks,  Historical Places and Technology Invantions Areas" },
                    { 2, "America and Asia Africa", "City Parks,  Historical Places and Technology Invantions Areas" },
                    { 3, "America, Africa and Asia", "City Parks,  Historical Places and Technology Invantions Areas" },
                    { 4, "America and Asia", "City Parks,  Historical Places and Technology Invantions Areas" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Description", "EventDate", "Image", "LocationId", "Name" },
                values: new object[,]
                {
                    { 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus id feugiat quam. Etiam eros leo, faucibus iaculis tempor ac, faucibus ut velit. Sed nunc elit, efficitur tristique tristique eu, vestibulum et purus. Nullam at dolor ac elit elementum interdum. Donec eget enim vel orci convallis tincidunt at eget odio. Aliquam congue vel tortor vitae gravida. Vestibulum vulputate nisl vel semper posuere. Nulla elementum scelerisque odio, eu elementum nisi commodo sed. Donec aliquet venenatis faucibus. Donec lacinia ante dui, luctus viverra orci volutpat porttitor. Nullam non nunc elit. Proin gravida vulputate massa, eget posuere mi. Integer et fermentum velit. Quisque laoreet dignissim arcu, non malesuada odio dictum vel. Nam mollis ultricies massa eget blandit", new DateTime(2020, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://images.pexels.com/photos/466685/pexels-photo-466685.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500", 1, "Milano" },
                    { 21, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus id feugiat quam. Etiam eros leo, faucibus iaculis tempor ac, faucibus ut velit. Sed nunc elit, efficitur tristique tristique eu, vestibulum et purus. Nullam at dolor ac elit elementum interdum. Donec eget enim vel orci convallis tincidunt at eget odio. Aliquam congue vel tortor vitae gravida. Vestibulum vulputate nisl vel semper posuere. Nulla elementum scelerisque odio, eu elementum nisi commodo sed. Donec aliquet venenatis faucibus. Donec lacinia ante dui, luctus viverra orci volutpat porttitor. Nullam non nunc elit. Proin gravida vulputate massa, eget posuere mi. Integer et fermentum velit. Quisque laoreet dignissim arcu, non malesuada odio dictum vel. Nam mollis ultricies massa eget blandit", new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://images.pexels.com/photos/681335/pexels-photo-681335.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500", 2, "Bogota" },
                    { 20, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus id feugiat quam. Etiam eros leo, faucibus iaculis tempor ac, faucibus ut velit. Sed nunc elit, efficitur tristique tristique eu, vestibulum et purus. Nullam at dolor ac elit elementum interdum. Donec eget enim vel orci convallis tincidunt at eget odio. Aliquam congue vel tortor vitae gravida. Vestibulum vulputate nisl vel semper posuere. Nulla elementum scelerisque odio, eu elementum nisi commodo sed. Donec aliquet venenatis faucibus. Donec lacinia ante dui, luctus viverra orci volutpat porttitor. Nullam non nunc elit. Proin gravida vulputate massa, eget posuere mi. Integer et fermentum velit. Quisque laoreet dignissim arcu, non malesuada odio dictum vel. Nam mollis ultricies massa eget blandit", new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://images.pexels.com/photos/1105766/pexels-photo-1105766.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500", 2, "WA,DC" },
                    { 18, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus id feugiat quam. Etiam eros leo, faucibus iaculis tempor ac, faucibus ut velit. Sed nunc elit, efficitur tristique tristique eu, vestibulum et purus. Nullam at dolor ac elit elementum interdum. Donec eget enim vel orci convallis tincidunt at eget odio. Aliquam congue vel tortor vitae gravida. Vestibulum vulputate nisl vel semper posuere. Nulla elementum scelerisque odio, eu elementum nisi commodo sed. Donec aliquet venenatis faucibus. Donec lacinia ante dui, luctus viverra orci volutpat porttitor. Nullam non nunc elit. Proin gravida vulputate massa, eget posuere mi. Integer et fermentum velit. Quisque laoreet dignissim arcu, non malesuada odio dictum vel. Nam mollis ultricies massa eget blandit", new DateTime(2021, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://images.pexels.com/photos/3065260/pexels-photo-3065260.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500", 2, "Osaka" },
                    { 16, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus id feugiat quam. Etiam eros leo, faucibus iaculis tempor ac, faucibus ut velit. Sed nunc elit, efficitur tristique tristique eu, vestibulum et purus. Nullam at dolor ac elit elementum interdum. Donec eget enim vel orci convallis tincidunt at eget odio. Aliquam congue vel tortor vitae gravida. Vestibulum vulputate nisl vel semper posuere. Nulla elementum scelerisque odio, eu elementum nisi commodo sed. Donec aliquet venenatis faucibus. Donec lacinia ante dui, luctus viverra orci volutpat porttitor. Nullam non nunc elit. Proin gravida vulputate massa, eget posuere mi. Integer et fermentum velit. Quisque laoreet dignissim arcu, non malesuada odio dictum vel. Nam mollis ultricies massa eget blandit", new DateTime(2021, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://images.pexels.com/photos/416998/pexels-photo-416998.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500", 2, "Toronto" },
                    { 15, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus id feugiat quam. Etiam eros leo, faucibus iaculis tempor ac, faucibus ut velit. Sed nunc elit, efficitur tristique tristique eu, vestibulum et purus. Nullam at dolor ac elit elementum interdum. Donec eget enim vel orci convallis tincidunt at eget odio. Aliquam congue vel tortor vitae gravida. Vestibulum vulputate nisl vel semper posuere. Nulla elementum scelerisque odio, eu elementum nisi commodo sed. Donec aliquet venenatis faucibus. Donec lacinia ante dui, luctus viverra orci volutpat porttitor. Nullam non nunc elit. Proin gravida vulputate massa, eget posuere mi. Integer et fermentum velit. Quisque laoreet dignissim arcu, non malesuada odio dictum vel. Nam mollis ultricies massa eget blandit", new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://images.pexels.com/photos/302769/pexels-photo-302769.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500", 2, "Zurich" },
                    { 14, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus id feugiat quam. Etiam eros leo, faucibus iaculis tempor ac, faucibus ut velit. Sed nunc elit, efficitur tristique tristique eu, vestibulum et purus. Nullam at dolor ac elit elementum interdum. Donec eget enim vel orci convallis tincidunt at eget odio. Aliquam congue vel tortor vitae gravida. Vestibulum vulputate nisl vel semper posuere. Nulla elementum scelerisque odio, eu elementum nisi commodo sed. Donec aliquet venenatis faucibus. Donec lacinia ante dui, luctus viverra orci volutpat porttitor. Nullam non nunc elit. Proin gravida vulputate massa, eget posuere mi. Integer et fermentum velit. Quisque laoreet dignissim arcu, non malesuada odio dictum vel. Nam mollis ultricies massa eget blandit", new DateTime(2021, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://images.pexels.com/photos/374811/pexels-photo-374811.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500", 2, "Berlin" },
                    { 13, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus id feugiat quam. Etiam eros leo, faucibus iaculis tempor ac, faucibus ut velit. Sed nunc elit, efficitur tristique tristique eu, vestibulum et purus. Nullam at dolor ac elit elementum interdum. Donec eget enim vel orci convallis tincidunt at eget odio. Aliquam congue vel tortor vitae gravida. Vestibulum vulputate nisl vel semper posuere. Nulla elementum scelerisque odio, eu elementum nisi commodo sed. Donec aliquet venenatis faucibus. Donec lacinia ante dui, luctus viverra orci volutpat porttitor. Nullam non nunc elit. Proin gravida vulputate massa, eget posuere mi. Integer et fermentum velit. Quisque laoreet dignissim arcu, non malesuada odio dictum vel. Nam mollis ultricies massa eget blandit", new DateTime(2021, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://images.pexels.com/photos/1738997/pexels-photo-1738997.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500", 2, "Seoul" },
                    { 12, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus id feugiat quam. Etiam eros leo, faucibus iaculis tempor ac, faucibus ut velit. Sed nunc elit, efficitur tristique tristique eu, vestibulum et purus. Nullam at dolor ac elit elementum interdum. Donec eget enim vel orci convallis tincidunt at eget odio. Aliquam congue vel tortor vitae gravida. Vestibulum vulputate nisl vel semper posuere. Nulla elementum scelerisque odio, eu elementum nisi commodo sed. Donec aliquet venenatis faucibus. Donec lacinia ante dui, luctus viverra orci volutpat porttitor. Nullam non nunc elit. Proin gravida vulputate massa, eget posuere mi. Integer et fermentum velit. Quisque laoreet dignissim arcu, non malesuada odio dictum vel. Nam mollis ultricies massa eget blandit", new DateTime(2021, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://images.pexels.com/photos/2116721/pexels-photo-2116721.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500", 2, "Chicago" },
                    { 19, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus id feugiat quam. Etiam eros leo, faucibus iaculis tempor ac, faucibus ut velit. Sed nunc elit, efficitur tristique tristique eu, vestibulum et purus. Nullam at dolor ac elit elementum interdum. Donec eget enim vel orci convallis tincidunt at eget odio. Aliquam congue vel tortor vitae gravida. Vestibulum vulputate nisl vel semper posuere. Nulla elementum scelerisque odio, eu elementum nisi commodo sed. Donec aliquet venenatis faucibus. Donec lacinia ante dui, luctus viverra orci volutpat porttitor. Nullam non nunc elit. Proin gravida vulputate massa, eget posuere mi. Integer et fermentum velit. Quisque laoreet dignissim arcu, non malesuada odio dictum vel. Nam mollis ultricies massa eget blandit", new DateTime(2021, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://images.pexels.com/photos/416998/pexels-photo-416998.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500", 3, "Tokyo" },
                    { 11, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus id feugiat quam. Etiam eros leo, faucibus iaculis tempor ac, faucibus ut velit. Sed nunc elit, efficitur tristique tristique eu, vestibulum et purus. Nullam at dolor ac elit elementum interdum. Donec eget enim vel orci convallis tincidunt at eget odio. Aliquam congue vel tortor vitae gravida. Vestibulum vulputate nisl vel semper posuere. Nulla elementum scelerisque odio, eu elementum nisi commodo sed. Donec aliquet venenatis faucibus. Donec lacinia ante dui, luctus viverra orci volutpat porttitor. Nullam non nunc elit. Proin gravida vulputate massa, eget posuere mi. Integer et fermentum velit. Quisque laoreet dignissim arcu, non malesuada odio dictum vel. Nam mollis ultricies massa eget blandit", new DateTime(2022, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://images.pexels.com/photos/58603/pexels-photo-58603.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500", 2, "Barcelona" },
                    { 9, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus id feugiat quam. Etiam eros leo, faucibus iaculis tempor ac, faucibus ut velit. Sed nunc elit, efficitur tristique tristique eu, vestibulum et purus. Nullam at dolor ac elit elementum interdum. Donec eget enim vel orci convallis tincidunt at eget odio. Aliquam congue vel tortor vitae gravida. Vestibulum vulputate nisl vel semper posuere. Nulla elementum scelerisque odio, eu elementum nisi commodo sed. Donec aliquet venenatis faucibus. Donec lacinia ante dui, luctus viverra orci volutpat porttitor. Nullam non nunc elit. Proin gravida vulputate massa, eget posuere mi. Integer et fermentum velit. Quisque laoreet dignissim arcu, non malesuada odio dictum vel. Nam mollis ultricies massa eget blandit", new DateTime(2020, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://images.pexels.com/photos/1334605/pexels-photo-1334605.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=300", 2, "Ny City" },
                    { 8, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus id feugiat quam. Etiam eros leo, faucibus iaculis tempor ac, faucibus ut velit. Sed nunc elit, efficitur tristique tristique eu, vestibulum et purus. Nullam at dolor ac elit elementum interdum. Donec eget enim vel orci convallis tincidunt at eget odio. Aliquam congue vel tortor vitae gravida. Vestibulum vulputate nisl vel semper posuere. Nulla elementum scelerisque odio, eu elementum nisi commodo sed. Donec aliquet venenatis faucibus. Donec lacinia ante dui, luctus viverra orci volutpat porttitor. Nullam non nunc elit. Proin gravida vulputate massa, eget posuere mi. Integer et fermentum velit. Quisque laoreet dignissim arcu, non malesuada odio dictum vel. Nam mollis ultricies massa eget blandit", new DateTime(2020, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://images.pexels.com/photos/1036657/pexels-photo-1036657.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500", 2, "Amsterdam" },
                    { 7, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus id feugiat quam. Etiam eros leo, faucibus iaculis tempor ac, faucibus ut velit. Sed nunc elit, efficitur tristique tristique eu, vestibulum et purus. Nullam at dolor ac elit elementum interdum. Donec eget enim vel orci convallis tincidunt at eget odio. Aliquam congue vel tortor vitae gravida. Vestibulum vulputate nisl vel semper posuere. Nulla elementum scelerisque odio, eu elementum nisi commodo sed. Donec aliquet venenatis faucibus. Donec lacinia ante dui, luctus viverra orci volutpat porttitor. Nullam non nunc elit. Proin gravida vulputate massa, eget posuere mi. Integer et fermentum velit. Quisque laoreet dignissim arcu, non malesuada odio dictum vel. Nam mollis ultricies massa eget blandit", new DateTime(2021, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://images.pexels.com/photos/3065260/pexels-photo-3065260.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500", 2, "Copenhagen" },
                    { 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus id feugiat quam. Etiam eros leo, faucibus iaculis tempor ac, faucibus ut velit. Sed nunc elit, efficitur tristique tristique eu, vestibulum et purus. Nullam at dolor ac elit elementum interdum. Donec eget enim vel orci convallis tincidunt at eget odio. Aliquam congue vel tortor vitae gravida. Vestibulum vulputate nisl vel semper posuere. Nulla elementum scelerisque odio, eu elementum nisi commodo sed. Donec aliquet venenatis faucibus. Donec lacinia ante dui, luctus viverra orci volutpat porttitor. Nullam non nunc elit. Proin gravida vulputate massa, eget posuere mi. Integer et fermentum velit. Quisque laoreet dignissim arcu, non malesuada odio dictum vel. Nam mollis ultricies massa eget blandit", new DateTime(2020, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://images.pexels.com/photos/1525612/pexels-photo-1525612.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500", 2, "London" },
                    { 17, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus id feugiat quam. Etiam eros leo, faucibus iaculis tempor ac, faucibus ut velit. Sed nunc elit, efficitur tristique tristique eu, vestibulum et purus. Nullam at dolor ac elit elementum interdum. Donec eget enim vel orci convallis tincidunt at eget odio. Aliquam congue vel tortor vitae gravida. Vestibulum vulputate nisl vel semper posuere. Nulla elementum scelerisque odio, eu elementum nisi commodo sed. Donec aliquet venenatis faucibus. Donec lacinia ante dui, luctus viverra orci volutpat porttitor. Nullam non nunc elit. Proin gravida vulputate massa, eget posuere mi. Integer et fermentum velit. Quisque laoreet dignissim arcu, non malesuada odio dictum vel. Nam mollis ultricies massa eget blandit", new DateTime(2021, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://images.pexels.com/photos/1485894/pexels-photo-1485894.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500", 1, "Sydney" },
                    { 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus id feugiat quam. Etiam eros leo, faucibus iaculis tempor ac, faucibus ut velit. Sed nunc elit, efficitur tristique tristique eu, vestibulum et purus. Nullam at dolor ac elit elementum interdum. Donec eget enim vel orci convallis tincidunt at eget odio. Aliquam congue vel tortor vitae gravida. Vestibulum vulputate nisl vel semper posuere. Nulla elementum scelerisque odio, eu elementum nisi commodo sed. Donec aliquet venenatis faucibus. Donec lacinia ante dui, luctus viverra orci volutpat porttitor. Nullam non nunc elit. Proin gravida vulputate massa, eget posuere mi. Integer et fermentum velit. Quisque laoreet dignissim arcu, non malesuada odio dictum vel. Nam mollis ultricies massa eget blandit", new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://images.pexels.com/photos/936722/pexels-photo-936722.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500", 1, "Mexico" },
                    { 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus id feugiat quam. Etiam eros leo, faucibus iaculis tempor ac, faucibus ut velit. Sed nunc elit, efficitur tristique tristique eu, vestibulum et purus. Nullam at dolor ac elit elementum interdum. Donec eget enim vel orci convallis tincidunt at eget odio. Aliquam congue vel tortor vitae gravida. Vestibulum vulputate nisl vel semper posuere. Nulla elementum scelerisque odio, eu elementum nisi commodo sed. Donec aliquet venenatis faucibus. Donec lacinia ante dui, luctus viverra orci volutpat porttitor. Nullam non nunc elit. Proin gravida vulputate massa, eget posuere mi. Integer et fermentum velit. Quisque laoreet dignissim arcu, non malesuada odio dictum vel. Nam mollis ultricies massa eget blandit", new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://images.pexels.com/photos/1525612/pexels-photo-1525612.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500", 1, "New Delh" },
                    { 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus id feugiat quam. Etiam eros leo, faucibus iaculis tempor ac, faucibus ut velit. Sed nunc elit, efficitur tristique tristique eu, vestibulum et purus. Nullam at dolor ac elit elementum interdum. Donec eget enim vel orci convallis tincidunt at eget odio. Aliquam congue vel tortor vitae gravida. Vestibulum vulputate nisl vel semper posuere. Nulla elementum scelerisque odio, eu elementum nisi commodo sed. Donec aliquet venenatis faucibus. Donec lacinia ante dui, luctus viverra orci volutpat porttitor. Nullam non nunc elit. Proin gravida vulputate massa, eget posuere mi. Integer et fermentum velit. Quisque laoreet dignissim arcu, non malesuada odio dictum vel. Nam mollis ultricies massa eget blandit", new DateTime(2020, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://images.pexels.com/photos/417192/pexels-photo-417192.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500", 1, "Miami" },
                    { 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus id feugiat quam. Etiam eros leo, faucibus iaculis tempor ac, faucibus ut velit. Sed nunc elit, efficitur tristique tristique eu, vestibulum et purus. Nullam at dolor ac elit elementum interdum. Donec eget enim vel orci convallis tincidunt at eget odio. Aliquam congue vel tortor vitae gravida. Vestibulum vulputate nisl vel semper posuere. Nulla elementum scelerisque odio, eu elementum nisi commodo sed. Donec aliquet venenatis faucibus. Donec lacinia ante dui, luctus viverra orci volutpat porttitor. Nullam non nunc elit. Proin gravida vulputate massa, eget posuere mi. Integer et fermentum velit. Quisque laoreet dignissim arcu, non malesuada odio dictum vel. Nam mollis ultricies massa eget blandit", new DateTime(2020, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://images.pexels.com/photos/466685/pexels-photo-466685.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500", 1, "Beijing" },
                    { 10, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus id feugiat quam. Etiam eros leo, faucibus iaculis tempor ac, faucibus ut velit. Sed nunc elit, efficitur tristique tristique eu, vestibulum et purus. Nullam at dolor ac elit elementum interdum. Donec eget enim vel orci convallis tincidunt at eget odio. Aliquam congue vel tortor vitae gravida. Vestibulum vulputate nisl vel semper posuere. Nulla elementum scelerisque odio, eu elementum nisi commodo sed. Donec aliquet venenatis faucibus. Donec lacinia ante dui, luctus viverra orci volutpat porttitor. Nullam non nunc elit. Proin gravida vulputate massa, eget posuere mi. Integer et fermentum velit. Quisque laoreet dignissim arcu, non malesuada odio dictum vel. Nam mollis ultricies massa eget blandit", new DateTime(2020, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://images.pexels.com/photos/1697358/pexels-photo-1697358.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500", 2, "Madrid" }
                });

            migrationBuilder.InsertData(
                table: "Upcomings",
                columns: new[] { "Id", "Description", "EventDate", "Image", "LocationId", "Name" },
                values: new object[,]
                {
                    { 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus id feugiat quam. Etiam eros leo, faucibus iaculis tempor ac, faucibus ut velit. Sed nunc elit, efficitur tristique tristique eu, vestibulum et purus. Nullam at dolor ac elit elementum interdum. Donec eget enim vel orci convallis tincidunt at eget odio. Aliquam congue vel tortor vitae gravida. Vestibulum vulputate nisl vel semper posuere. Nulla elementum scelerisque odio, eu elementum nisi commodo sed. Donec aliquet venenatis faucibus. Donec lacinia ante dui, luctus viverra orci volutpat porttitor. Nullam non nunc elit. Proin gravida vulputate massa, eget posuere mi. Integer et fermentum velit. Quisque laoreet dignissim arcu, non malesuada odio dictum vel. Nam mollis ultricies massa eget blandit", new DateTime(2020, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://images.pexels.com/photos/3065260/pexels-photo-3065260.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500", 2, "Osaka" },
                    { 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus id feugiat quam. Etiam eros leo, faucibus iaculis tempor ac, faucibus ut velit. Sed nunc elit, efficitur tristique tristique eu, vestibulum et purus. Nullam at dolor ac elit elementum interdum. Donec eget enim vel orci convallis tincidunt at eget odio. Aliquam congue vel tortor vitae gravida. Vestibulum vulputate nisl vel semper posuere. Nulla elementum scelerisque odio, eu elementum nisi commodo sed. Donec aliquet venenatis faucibus. Donec lacinia ante dui, luctus viverra orci volutpat porttitor. Nullam non nunc elit. Proin gravida vulputate massa, eget posuere mi. Integer et fermentum velit. Quisque laoreet dignissim arcu, non malesuada odio dictum vel. Nam mollis ultricies massa eget blandit", new DateTime(2020, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://images.pexels.com/photos/1105766/pexels-photo-1105766.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500", 2, "WA,DC" },
                    { 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus id feugiat quam. Etiam eros leo, faucibus iaculis tempor ac, faucibus ut velit. Sed nunc elit, efficitur tristique tristique eu, vestibulum et purus. Nullam at dolor ac elit elementum interdum. Donec eget enim vel orci convallis tincidunt at eget odio. Aliquam congue vel tortor vitae gravida. Vestibulum vulputate nisl vel semper posuere. Nulla elementum scelerisque odio, eu elementum nisi commodo sed. Donec aliquet venenatis faucibus. Donec lacinia ante dui, luctus viverra orci volutpat porttitor. Nullam non nunc elit. Proin gravida vulputate massa, eget posuere mi. Integer et fermentum velit. Quisque laoreet dignissim arcu, non malesuada odio dictum vel. Nam mollis ultricies massa eget blandit", new DateTime(2020, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://images.pexels.com/photos/416998/pexels-photo-416998.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500", 3, "Tokyo" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Upcomings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Upcomings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Upcomings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 3);
        }
    }
}
