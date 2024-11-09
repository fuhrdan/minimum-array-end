//*****************************************************************************
//** 3133. Minimum Array End    leetcode                                     **
//*****************************************************************************


long long minEnd(int n, int x) {
    n--;
    long long retNum = x;
    for (int i = 0; i < 31; i++) {
        if (((x >> i) & 1) ^ 1) {
            retNum |= (long long)((n & 1) << i);
            n >>= 1;
        }
    }
    retNum |= ((long long)n) << 31;
    return retNum;
}