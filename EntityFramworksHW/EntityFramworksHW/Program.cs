using EntityFramworksHW.Models;

using ( var db = new AcademyContext() ) {

    // Select all from Trainees table
    //foreach ( var Trainee in db.Trainees ) {
    //    Console.WriteLine(
    //        $"Customer {Trainee.Name} is a {Trainee.Course}, lives in {Trainee.Location} and favourite hobby is {Trainee.FavHobby}"
    //    );
    //}


    // Add new trainee
    //var newTrainee = new Trainee {
    //    Name = "Nash",
    //    Course = "Business Analyst",
    //    Location = "Coventry",
    //    FavHobby = "Skiing"
    //};

    //db.Trainees.Add( newTrainee );
    //db.SaveChanges();

    //var trainee = db.Trainees.Find( 4 );
    //Console.WriteLine( trainee );

    // Update Trainee info
    //var trainee = db.Trainees.Find( 4 );
    //trainee.FavHobby = "Basketball";
    //db.SaveChanges();

    //var updatedTrainee = db.Trainees.Find( 4 );
    //Console.WriteLine( updatedTrainee );

    var traineeToDelete = db.Trainees.Find( 4 );
    db.Trainees.Remove( traineeToDelete );
    db.SaveChanges();

    var deletedTrainee = db.Trainees.Find( 4 );
    if ( deletedTrainee == null ) {
        Console.WriteLine( "Successfull Deleted" );
    }
    else {
        Console.WriteLine( "Trainee Not Deleted" );
    }

}