#include <iostream>
#include <fstream> // Needed for file operations
#include <ctime>   // Needed for timestamp operations
#include <string>  // Needed for string operations (should have been included by default but wasn't working for me without)

using namespace std;

int main()
{
    string name, username;
    int age;

    cout << "What is your name?\n";
    getline(cin, name);

    cout << "What is your age?\n";
    cin >> age;
    cin.ignore(); // clear the newline from the buffer

    cout << "What is your github username?\n";
    getline(cin, username);

    cout << "Your name is " << name << ", you are " << age << " years old, and your github username is " << username << ".\n";

    // Get the current time and format it for logging
    time_t now = time(0);
    struct tm newtime;
    localtime_s(&newtime, &now);
    char buf[80];
    strftime(buf, sizeof(buf), "%Y-%m-%d %H:%M:%S", &newtime);
    string timestamp(buf);

    // Open the log file and write to it
    ofstream logFile("userlog.csv", ios::app); // open in append mode
    if (logFile.is_open())
    {
        logFile << timestamp << "," << name << "," << age << "," << username << "\n";
        logFile.close();
    }
    else
    {
        cout << "Unable to open the log file.\n";
    }

    return 0;
}