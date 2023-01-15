/* Write a program to find the number of digits in the given number */

#include<iostream>
using namespace std;

int countDigit(int);

int main(){
   // First cdig = new First();
    int myNumber , digitCount;
    cout << "Counting Digit of a given number " <<endl;
    cout << "Enter your number :" ;
    cin  >> myNumber;
    digitCount = countDigit(myNumber);
    cout << digitCount;
    return 0;
}

int countDigit(int digit){
    int result =0;
    while(digit >0){
        digit = digit/10;
        cout << "digit value " << digit <<endl;
        result++ ;
       // cout << "digit value " << digit;
    }
    
    return result ;
    cout << "The count of digit in your number is :" << result;
}


