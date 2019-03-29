#include <iostream>
#include <fstream>
#include <sstream>

using namespace std;

int main()
{
	//Create
	ofstream writer("file.txt");
	ifstream reader; reader.open("file.txt"); //ifstream reader("file.txt");

	//Write
	if (writer.is_open())
	{
		writer << "Write text" << endl;
		writer << "More text" << endl;

		cout << "Write success\n" << endl;
	}
	else
	{
		cout << "Something went wrong" << endl;
	}

	//Read
	if (reader.is_open())
	{
		stringstream stream;

		//Read the whole file into stream
		stream << reader.rdbuf();

		//Put stream into string
		string txt = stream.str();

		//Display string
		cout << "Read success: \n\n" << txt << endl;
	}
	else
	{
		cout << "Something went wrong" << endl;
	}

	//Close
	writer.close();
	reader.close();

	cout << "Press enter to exit ...";
	cin.get();
	return 0;
}