using System;

namespace Classlib1;

class C(
    [A] // Repro: Apply `Format document`.
	int i);

record R(
    [A] // Repro: Apply `Format document`.
	int I);

class AAttribute : Attribute;
