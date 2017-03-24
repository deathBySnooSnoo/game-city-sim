#include "gamecitysim.h"

using namespace std;

bool paused = false;
bool quit = false;
gametime gt;
thread timeThread;

int timePassage() {
	while (!paused) {
		gt.tick();
		this_thread::sleep_for(chrono::milliseconds(167));
	}
	return 0;
}

int main() {
	timeThread = thread(timePassage);
	string input;
	while (!quit) {
		cin >> input;
		if (input.compare("pause")) {
			paused = true;
		}
		else if (input.compare("quit")) {
			quit = true;
			paused = true;
			timeThread.join();
		}
	}
	exit(0);
}