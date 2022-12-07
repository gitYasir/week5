namespace EntityFramworksHW.Models;

public partial class Trainee {
    public override string ToString() {
        return $"ID: {Id} - Name: {Name} - Course: {Course} - Location: {Location} - Favourite Hobby: {FavHobby}";
    }
}
