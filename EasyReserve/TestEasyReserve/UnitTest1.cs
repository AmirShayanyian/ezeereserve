//using Domain.Entities;
//using Domain.Entities.Identities;
//using Domain.Enums;

//namespace TestEasyReserve
//{
//    public class UnitTest1
//    {
//        [Fact]
        
//            public void UserTestMethodToCheck(string name, string lastName)
//            {
//            User user = new User(name, lastName);

//                Assert.Equal(name, user.FirstName);
//                Assert.Equal(lastName, user.LastName);
//            }
//        }
//}

// Add necessary using statements for testing
using Domain.Entities;
using Domain.Enums;
using Xunit;

namespace TestEasyReserve
{
    public class AddressTests
    {
        [Fact]
        public void Address_ShouldHaveCorrectProperties()
        {
            // Arrange
            var address = new Address("TestStreet", "123", "TestCity", "12345");

            // Assert
            Assert.Equal("TestStreet", address.Street);
            Assert.Equal("123", address.HouseNumber);
            Assert.Equal("TestCity", address.City);
            Assert.Equal("12345", address.Zipcode);
        }
    }

    public class ArtistTests
    {
        [Fact]
        public void Artist_ShouldHaveCorrectProperties()
        {
            // Arrange
            var artist = new Artist { UserName = "TestArtist", Genre = new Genre { Description = "TestGenre" } };

            // Assert
            Assert.Equal("TestArtist", artist.UserName);
            Assert.NotNull(artist.Genre);
            Assert.Equal("TestGenre", artist.Genre.Description);
        }
    }

    public class CategoryTests
    {
        [Fact]
        public void Category_ShouldHaveCorrectProperties()
        {
            // Arrange
            var category = new Category { Id = 1, Description = "TestCategory" };

            // Assert
            Assert.Equal(1, category.Id);
            Assert.Equal("TestCategory", category.Description);
        }
    }

    public class ConcertTests
    {
        // Add more tests as provided in the previous response
    }

    public class GenreTests
    {
        [Fact]
        public void Genre_ShouldHaveCorrectProperties()
        {
            // Arrange
            var genre = new Genre { Description = "TestGenre" };

            // Assert
            Assert.Equal("TestGenre", genre.Description);
        }
    }

    public class PriceTests
    {
        [Fact]
        public void Price_ShouldHaveCorrectProperties()
        {
            // Arrange
            var price = new Price { Amount = 50.00m, PaymentType = "CreditCard", PaymentDate = new DateOnly(2023, 1, 1) };

            // Assert
            Assert.Equal(50.00m, price.Amount);
            Assert.Equal("CreditCard", price.PaymentType);
            Assert.Equal(new DateOnly(2023, 1, 1), price.PaymentDate);
        }
    }

    public class SeatTests
    {
        [Fact]
        public void Seat_ShouldHaveCorrectProperties()
        {
            // Arrange
            var seat = new Seat { SeatNr = "A1", Categories = new List<Category> { new Category { Id = 1, Description = "TestCategory" } } };

            // Assert
            Assert.Equal("A1", seat.SeatNr);
            Assert.Single(seat.Categories);
            Assert.Equal(1, seat.Categories[0].Id);
            Assert.Equal("TestCategory", seat.Categories[0].Description);
        }
    }

    public class TicketTests
    {
        [Fact]
        public void Ticket_ShouldHaveCorrectProperties()
        {
            // Arrange
            var concert = new Concert { ConcertId = 1, Genre = new Genre { Description = "TestGenre" } };
            var ticket = new Ticket { TicketNr = "12345", Price = 50.00m, SeatNr = "A1", Status = TicketStatus.Available, Concert = concert };

            // Assert
            Assert.Equal("12345", ticket.TicketNr);
            Assert.Equal(50.00m, ticket.Price);
            Assert.Equal("A1", ticket.SeatNr);
            Assert.Equal(TicketStatus.Available, ticket.Status);
            Assert.Equal(concert, ticket.Concert);
        }
    }

    public class VenueTests
    {
        [Fact]
        public void Venue_ShouldHaveCorrectProperties()
        {
            // Arrange
            var address = new Address("TestStreet", "123", "TestCity", "12345");
            var venue = new Venue { Name = "TestVenue", Address = address, Cpacity = 100 };

            // Assert
            Assert.Equal("TestVenue", venue.Name);
            Assert.Equal(address, venue.Address);
            Assert.Equal(100, venue.Cpacity);
        }
    }
}