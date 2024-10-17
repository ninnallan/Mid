/*შექმენით აბსტრაქტული კლასი "Bird" შემდეგი წევრებით:
აბსტრაქტული მეთოდი "MakeSound()" იმპლემენტაციის გარეშე.
*/
abstract class Bird
{
    public abstract string MakeSound();
}
/*შექმენით "Bird" კლასის მემკვიდრე კლასი "Sparrow", 
რომელიც უზრუნველყოფს "MakeSound()"-ის იმპლემენტაციას
 ტექსტის: "Chirp." დაბრუნებით. 
*/
class Sparrow : Bird
{
    public override string MakeSound()
    {
        return "Chirp";
    }
}
/*შექმენით კლასი "Pigeon", რომელიც ასევე არის "Bird"-ის შვილობილი,
 და აიმპლემენტირებს "MakeSound()"-ს და შედეგს აბრუნებს "Coo". 
*/
class Pigeon : Bird
{
    public override string MakeSound()
    {
        return "Coo";
    }
}
