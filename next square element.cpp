#include <iostream>
#include <stack>

using namespace std;

/*
Initially you have a 2x2 matrix, say zoom1:
a  b
c  d

zooming it results in a 4x4 matrix (zoom2) as follows:
aa ab ba bb
ac ad bc bd
ca cb da db
cc cd dc dd

zooming it again will result in an 8x8 matrix and so on..
aaaa aaab abaa abab baba babb bbba bbbb
aaac aaad abac abad babc babd bbbc bbbd
acaa acab adaa adab bcba bcbb bdba bdbb
acac acad adac adad bcbc bcbd bdbc bdbd
caca cacb cbca cbcb dada dadb dbda dbda
cacc cacd cbcc cbcd dadc dadd dbdc dbdd
ccca cccb cdca cdcb dcda dcdb ddda dddb
cccc cccd cdcc cdcd dcdc dcdd dddc dddd

The question is, given a sequence say abaaabadabaaabac we need to find out the sequence coming just left to it. 
For e.g. if the given sequence is "bd" for zoom2, the sequence coming just left to it is "bc". For "cd" it's "cc" etc.

algirithm:
from the zoom 8x8, use 'dcda' as example, which can be split to 'dc' and 'da', 'dc' indicates the index in zoom 4x4, 
'da' indicates current index started with 'dc'; 'dc' and 'da' share the same prefix character 'd' with length (2-1);

from the zoom 16x16, use 'abaaabadabaaabac' as example, which can be split to 'abaaabad' and 'abaaabac', they share the 
same prefix 'abaaaba' with length (8-1), 'c' in the second half is the index in the 4x4 matrix; we can continue to split
the first half 'abaaabad' to be 'abaa' and 'abad', they share the same prefix 'aba' (4-1), 'd' in the seocnd half is the index
in the 4x4 matrix; continue for the first half 'abaa' is split to be 'ab' and 'aa', they share same prefix 'a' (2-1)...

we can see, in the sequence, the bit contribute to the index actually is on 2 power N position at 1, 2, 4, 8, 16... Other
position is only duplicate. 

Then we can see, if the sequence is ended with 'c' or 'd', then change 'c' to 'a' or 'd' to 'c', then you are done. 
if it is ended with 'a' or 'c', it need to zoom in to upper level to find the left prefix, then append 'b' or 'd'.
*/


// To validate whether it is a input. this routine is optional
bool ValidateSequence( char* curSequence )
{
	if( !curSequence )
		return false;

	// Len must the 2 power of n
	int len = strlen(curSequence);
	if(len & (len-1) )
		return false;

	while( len>1 )
	{
		if( curSequence[len-1] != 'a' &&
			curSequence[len-1] != 'b' &&
			curSequence[len-1] != 'c' &&
			curSequence[len-1] != 'd' )
			return false;
		len /= 2;
		if(strncmp(curSequence, curSequence+len, len-1 ) != 0 )
			return false;
	}

	return true;
}

// this is the algorithm to find the left sequence.
// Note: the stack is not required, but make the code more readable
char* FindLeftSequence( char* curSequence)
{
	if( ValidateSequence( curSequence ) == false )
		return NULL;

	int len = strlen( curSequence );
	char *leftSequence = new char[len+1];
	int curLen = len;
	stack<char> output;

	while( curLen )
	{
		char cur = curSequence[curLen-1];
		if( cur == 'a' )
		{
			output.push('b');
		}
		else if( cur == 'c' )
		{
			output.push('d');
		}
		else if( cur == 'b' )
		{
			// No need to zoom in, copy curSequence to leftSequence and update the last character
			strncpy( leftSequence, curSequence, curLen );
			leftSequence[curLen-1] = 'a';
			leftSequence[curLen] = '\0';
			break;
		}
		else
		{
			// No need to zoom in, copy curSequence to leftSequence and update the last character
			strncpy( leftSequence, curSequence, curLen );
			leftSequence[curLen-1] = 'c';
			leftSequence[curLen] = '\0';
			break;
		}
		curLen /=2;
	}
		
	if( curLen == 0 )
	{
		// Cannot find the left sequence as current sequence is on the left most already
		delete [] leftSequence;
		return NULL;
	}

	while( !output.empty() )
	{
		if( curLen != strlen(leftSequence) )
			throw;
		char cur = output.top();
		output.pop();
		strncpy(leftSequence+curLen, leftSequence, curLen);
		curLen*=2;
		leftSequence[curLen-1]= cur;
		leftSequence[curLen]='\0';
	}

	if( curLen != len )
		throw;

	return leftSequence;
}

typedef struct _STRINGS{
	char * String;
	char * LeftString;
	bool IsMatch;
} STRING, *PSTRING;

STRING TestStrings[]=
{
	{"ad", "ac", true},
	{"da", "cb", true},
	{"ca", "*", false},
	{"caca", "*", false},
	{"bcbc", "adad", true},
	{"dadc", "cbcd", true},
	{"bcbb", "bcba", true},
	{"cccc", "*", false},
	{"abadabaa","abacabab",true},
	{"bcbcbcba","adadadab",true},
	{"cacccaca","*",false},
	{"bcbcbc","*",false}
};

int main(void)
{
	char * output = NULL;
	int len = sizeof(TestStrings)/sizeof(STRING);
	bool succeed = true;

	for( int i=0; i<len; i++ )
	{
		output = FindLeftSequence( TestStrings[i].String );
		if( output )
		{
			if( strcmp( TestStrings[i].LeftString, output ) != 0 )
			{
				cout<<"string "<<TestStrings[i].String<<" test fails as it expects "<<TestStrings[i].LeftString<<" but get "<<output<<endl;
				succeed = false;
			}
			delete [] output;
			output = NULL;
		}
		else
		{
			if( TestStrings[i].IsMatch == true )
			{
				cout<<"string "<<TestStrings[i].String<<" test fails as it expects "<<TestStrings[i].LeftString<<" but get null"<<endl;
				succeed = false;
			}
		}
	}

	if( succeed )
	{
		cout<<"All test run passed!!!"<<endl;
	}

	cout<<"Press any key to terminate"<<endl;
	return getchar();
}