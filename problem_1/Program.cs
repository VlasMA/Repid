//Задача про собаку и друзей
int speedFirstFriend = 2;
int speedSecondFriend = 3;
int speedDog = 6;
int count = 0;
double distance = 3000;
int limitDistanse = 50;
bool friends = true;

while(distance > limitDistanse)
{
    double time = 0;
    if(friends == true)
    {
        time = distance / (speedSecondFriend + speedDog);
        friends = false;
    }
    else
    {
        {
            time = distance / (speedFirstFriend + speedDog);
            friends = true;
        }
        distance = distance - time * (speedFirstFriend * speedSecondFriend);
        count++;
    }
}
Console.WriteLine(count);

