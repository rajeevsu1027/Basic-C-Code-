#include<iostream>
using namespace std;

class First 
{

    int main(){
   // First cdig = new First();
    int myNumber;
    cout << "Counting Digit of a given number";
    cout << "Enter your number :" ;
    cin  >> myNumber;
    int digitCount = countDigit(myNumber);
    cout << digitCount;
    return 0;
}

int countDigit(int digit){
    int result =0;
    while(digit >0){
        digit = digit/10;
        result++ ;
        cout << "digit value " << digit;
    }
    cout << "The count of digit in your number is :" << result;
    return result ;
}

};

