class LRUCache{
private:
    int size;
    typedef pair<int, int> EntryPair;
    list<EntryPair> cacheList;
    unordered_map<int, list<EntryPair>::iterator> cacheMap;
    
    void movetoFront(list<EntryPair>::iterator &iter) {
        if (iter != cacheList.begin()) {
            cacheList.splice(cacheList.begin(), cacheList, iter);
        }
    }
    
public:
    LRUCache(int capacity) {
        size = capacity;
        //cacheList = new list<EntryPair(size);
        //cacheMap = new unorder_map<int, list<EntryPair>::iterator>(size);
    }
    
    int get(int key) {
        auto iter = cacheMap.find(key);
        if (iter == cacheMap.end()) {
            return -1;
        }
        
        movetoFront(iter->second);
        return cacheList.front().second;
    }
    
    void set(int key, int value) {
        if (cacheMap.find(key) != cacheMap.end()) {
            *cacheMap[key] = make_pair(key, value);
            movetoFront(cacheMap[key]);
        } else {
            if (cacheMap.size() == size) {
                cacheMap.erase(cacheList.back().first);
                cacheList.back() = make_pair(key, value);
                movetoFront(--cacheList.end());
            } else {
                cacheList.emplace(cacheList.begin(), key, value);
            }
            cacheMap[key] = cacheList.begin();
        }
    }
};