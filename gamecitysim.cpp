#include "gamecitysim.h"

using namespace std;

bool paused = false;
gametime gt;


int main() {
	
	while (!paused) {
		gt.tick();
		this_thread::sleep_for(chrono::milliseconds(167));
	}
}