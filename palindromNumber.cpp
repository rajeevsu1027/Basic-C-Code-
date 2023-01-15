/* Write a program to find if the given number is palindrome or not*/

#include<iostream>
using namespace std;

bool isPalindrome(int);

int main(){
   // First cdig = new First();
    int myNumber ;
    bool Result;
    cout << "Checking number is palindrome " <<endl;
    cout << "Enter your number :" ;
    cin  >> myNumber;
    Result = isPalindrome(myNumber);

    if(Result == 1)
    {
      cout << "Given number is palidrome" <<endl;
    }else {
      cout << "Given number is not palidrome" <<endl;
    }
    
    return 0;
}

bool isPalindrome(int digit){
    int rev =0;
    int temp = digit;
    while(temp != 0){
        int lastDigit = temp%10;
        rev = rev * 10 + lastDigit;
        temp = temp/10;
    }

    // if(rev == digit)
    //  {
    //     cout << "Given number is palidrome" <<endl;;
    //     return (rev == digit);
    //  }
    //  else {
    //     cout << "Given number is not palidrome" <<endl;;
    //     return (rev != digit);
    //  }
    
    return (rev == digit);
}


