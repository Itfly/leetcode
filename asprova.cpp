#include <Windows.h>
#include <stdio.h>
#include <string.h>
#include <time.h>
#define MAX_PATH 1000
#define BUFFER_SIZE 32*1024
int lines = 0;
char buffer[BUFFER_SIZE];

inline int countLines(FILE *fp) {	
	if (feof (fp)) {
         return 0;
	}
	
	int total = 0;
	int read;
	
	while ((read = fread(buffer, sizeof(char), BUFFER_SIZE, fp)) > 0) {
		for (int i = 0; i < read; i++) {
			if (buffer[i] == '\n') {
				total++;
			}
		}
	}
	return total;
	
}


void findAllFile(LPCTSTR lpszPath) {
	TCHAR szFind[MAX_PATH];
	lstrcpy(szFind, lpszPath);
	lstrcat(szFind, "\\*.*");
	WIN32_FIND_DATA wfd;
	HANDLE hFind = FindFirstFile(szFind, &wfd);
	if (hFind == INVALID_HANDLE_VALUE) {
		return;
	}
	do {
		if (wfd.cFileName[0] == '.')
			continue;
		if (wfd.dwFileAttributes & FILE_ATTRIBUTE_DIRECTORY) {
			TCHAR szFile[MAX_PATH];
			wsprintf(szFile, "%s\\%s", lpszPath, wfd.cFileName);
			findAllFile(szFile);
		} else {
			TCHAR szFile[MAX_PATH];
			wsprintf(szFile, "%s\\%s", lpszPath, wfd.cFileName);
			FILE *fp;
			if ((fp = fopen(szFile, "r")) == NULL) {
				printf("文件打开失败!\n");
			} else {
				lines += countLines(fp);
				//int count = 0;
				
				//while (fgets(buffer, 1000, fp)!= NULL) lines++;
				fclose(fp);
			}
			
		}

	} while (FindNextFile(hFind, &wfd));
	FindClose(hFind);
}

int main() {
	LPCTSTR path = "C:\\Windows\\System32";
	//DWORD dwStart = GetTickCount();
	time_t begin, end;
	begin = clock();
	findAllFile(path);
	end = clock();
	//DWORD dwEnd = GetTickCount();
	printf("共有%d行代码\n", lines);
	printf("耗时%d\n", end-begin);
	getchar();getchar();
	return 0;
}