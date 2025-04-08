public class Solution {
    public int NumTilePossibilities(string tiles) {
        HashSet<string> hashset = new HashSet<string>(); 
        bool[] visit = new bool[tiles.Length];
        
        for(int i=0;i<tiles.Length;i++){
            visit[i] = true;
            hashset.Add(tiles[i].ToString());
            DFS(tiles,tiles[i].ToString(),visit,hashset);
            visit[i] = false;
        }

        return hashset.Count;
    }

    public void DFS(string tiles, string str, bool[] visit, HashSet<string> hashset){
        bool isFull = true;

        for(int i=0;i<visit.Length;i++){
            if(!visit[i]){
                isFull = false;
            }
        }

        if(isFull){
            return;
        }

        for(int i=0;i<tiles.Length;i++){
            if(visit[i]){
                continue;
            }

            hashset.Add(str+tiles[i]);
            visit[i] = true;
            DFS(tiles,str+tiles[i],visit,hashset);
            visit[i] = false;
        }
    }
}