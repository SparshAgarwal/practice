/**
 * Created by sparsh on 2/5/17.
 */
public class Solution {
}


    void StairCase(int n) {
        for(int i=n-1; i>=0; i--){
            cout<<string(i,' ')<<string(n-i, '#')<<"\n";
        }
    }
