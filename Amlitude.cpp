#include "pch.h"
#include <utility>
#include <limits.h>
#include "Amplitude.h"

struct pair Func(time_t t,double v)
{
	struct pair tmp = {t, v};
	return tmp;
}
