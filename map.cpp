#include "map.h"

using namespace std;

vector<vector<lot>> lots(5, vector<lot>(5));

map::map() {
	for (int i = 0; i < lots.size; i++) {
		for (int j = 0; j < lots[i].size; j++) {
			lots[i].push_back(lot());
		}
	}
}

map::~map() {

}