# Complexity Assessment

1.

```cs
int a = 0, b = 0;
for (i = 0; i < N; i++)
{
	a = a + rand();
}
for (j = 0; j < M; j++)
{
	b = b + rand();
}
```

Complexity: O(N*2)


2.

```cs
int a = 0;
for (i = 0; i < N; i++)
{
	for (j = N; j > i; j--)
	{
		a = a + i + j;
	}
}
```
Complexity: O(N^2)

3.
```cs
int i, j, k = 0;
for (i = n / 2; i <= n; i++)
{
	for (j = 2; j <= n; j = j * 2)
	{
		k = k + n / 2;
	}
}
```

4.
```cs
int a = 0, i = N;
while (i > 0)
{
	a += i;
	i /= 2;
}
```

5.
```cs
for (var i = 0; i < n; i++)
	i *= k
6.
var value = 0;
for (var i = 0; i < n; i++)
	for (var j = 0; j < i; j++)
		value += 1;
```